function solve(params) {
    let energy = 100;
    let coins = 100;

    let tokens = params[0].split('|').filter(x => x !== '');
    let index = 0;
    while (coins > 0 && index < tokens.length) {
        let token = tokens[index].split('-').filter(x => x !== '');
        let name = token[0];
        let number = Number(token[1]);
        switch (name) {
            case 'rest':
                let energyGain = (energy + number) <= 100 ? number : (100 - energy);
                energy += energyGain;
                console.log(`You gained ${energyGain} energy.\nCurrent energy: ${energy}.`)
                break;
            case 'order':
                energy -= 30;
                if (energy < 0) {
                    console.log('You had to rest!')
                    energy += 80;
                } else {
                    console.log(`You earned ${number} coins.`)
                    coins += number;
                }
                break;
            default:
                coins -= number;
                console.log(coins > 0 ?
                    `You bought ${name}.` :
                    `Closed! Cannot afford ${name}.`
                );
                break;
        }
        index++;
    }
    if (coins > 0) {
        console.log(`Day completed!\nCoins: ${coins}\nEnergy: ${energy}`)
    }
}
solve(['rest-2|order-10|eggs-100|rest-10'])