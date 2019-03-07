function solve([str]) {
    function printMessage(message) { //помощна функция която да отговаря за принтирането на съобщенията
        console.log(message);
    }

    let energy = 100;   //първоначална енергия
    let coins = 100;    //първоначални пари
    let workingDayEvents = str.split('|');  //сплитваме входните данни и ги записваме в масив

    for (let day of workingDayEvents) { //обхождаме всеки ден от workingDayEvents
        let tokens = day.split('-');    //сплитваме (евента или продукта) и стойността от стринга с -
        let content = tokens[0];        //евента за деня или съставката която трябва да се купи
        let value = Number(tokens[1]);  //стойността на евента или продукта
        let message = '';               //съобщението което ще принтираме след всяка итерация 

        switch (content) {              //суичваме по content (евента или продукта)
            case 'rest':                
                let gainedEnergy = Math.min(value, 100 - energy); //изчисляваме колко енергия ще получим така че да не превишим 100
                energy += gainedEnergy; //добавяме към нашата енергия изчислената gainedEnergy
                message = `You gained ${gainedEnergy} energy.\nCurrent energy: ${energy}.`; //задаваме стойност на съобщението ни
                break;
            case 'order':
                if (energy - 30 < 0) {  //ако след опит за поръчка енергията ни падне под 0
                    energy += 50;       //добавяме 50 енергия
                    message = `You had to rest!`; //задаваме стойност на съобщението ни
                } else {                //ако можем да изпълним поръчката
                    energy -= 30;       //вадим 30 от енергията
                    coins += value;     //добавяме парите
                    message = `You earned ${value} coins.`; //задаваме стойност на съобщението ни
                }
                break;
            default:            //ако трябва да купуваме продукт
                coins -= value; //изваждаме от парите ни цената на продукта

                if (coins > 0) { //не сме банкрутирали                      
                    message = `You bought ${content}.`; //задаваме стойност на съобщението ни
                } else {    //банкрутирали сме
                    message = `Closed! Cannot afford ${content}.`; //задаваме стойност на съобщението ни
                }
                break;
        }

        printMessage(message); //извикваме функцията printMessage с настоящото съобщение

        if (coins <= 0) { //при банкрут прекратяваме итерирането по масива (банкрут)
            break;
        }
    }

    if (coins > 0) {    //ако не сме банкрутирали
        printMessage(`Day completed!\nCoins: ${coins}\nEnergy: ${energy}`);
    }
}

solve(['rest-2|order-10|eggs-100|rest-10 ']);