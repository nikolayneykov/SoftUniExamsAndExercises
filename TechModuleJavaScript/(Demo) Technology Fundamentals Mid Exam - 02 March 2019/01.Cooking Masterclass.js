function solve([budget, students, flourPrice, eggPrice, apronPrice]) {
    let freePackages = Math.floor(students / 5);                 //изчисляваме безплатните пакети брашно

    let totalPrice = (apronPrice * Math.ceil(students * 1.2)) +  //цена за aprons (студентите ги увеличаваме с 20% и закръгляме нагоре)
                     (eggPrice * 10 * students) +                //цена за яйцата
                     (flourPrice * (students - freePackages));   //цена за бращното минус безплатните пакети
    
    console.log(budget >= totalPrice ?                           //принтираме резултата
        `Items purchased for ${totalPrice.toFixed(2)}$.` :
        `${(totalPrice - budget).toFixed(2)}$ more needed.`);
}

solve([50, 2, 1.0, 0.10, 10.0]);

