function solve(batches) {
    batches.pop(); //махаме последния елемент
    let bestBatch = [Number.MIN_SAFE_INTEGER];  //създваме масив за най-добрата партида с 1 елемент (най-ниското отрицателно число)

    for (let batch of batches) {    //обхождаме партидите
        let currentBatch = batch.split('#').map(Number);    //сплитваме настоящата партида по # (става на масив) и парсваме към число 
        let foundBetterBatch = false; //булева променлива за това дали сме намерили по-добра партида

        if (sum(bestBatch) < sum(currentBatch)) {   //проверка по първи критерий (ако сумата на най-добрата партида е по малка от сумата на настоящата)
            foundBetterBatch = true;                
        } else if (sum(bestBatch) === sum(currentBatch)) {    //при равни суми
            if (average(bestBatch) < average(currentBatch)) { //втори критерий сравняваме средноаритметичните суми
                foundBetterBatch = true;
            } else if (average(bestBatch) === average(currentBatch) &&  //при равни средноаритметични суми
                bestBatch.length > currentBatch.length) {               //сравняваме по трети критерий (дължина на партидите)
                foundBetterBatch = true;
            }
        }

        if (foundBetterBatch) {                 //ако е намерена по-добра партида
            bestBatch = currentBatch.slice();   //най-добрата ни партида става настоящата
        }
    }

    console.log(`Best Batch quality: ${sum(bestBatch)}\n${bestBatch.join(' ')}`); //принтираме резултата


    function sum(arr) { 
        return arr.reduce((a, b) => a + b, 0); //помощна функция връща сумата от числата на масив
    }

    function average(arr) {
        return sum(arr) / arr.length; //помощна функция връща средноаритметичната сума на масив
    }
}

solve([
    '5#3#2',
    '10#2#-2#1#-1',
    '4#2#1',
    'Bake It!',
]);