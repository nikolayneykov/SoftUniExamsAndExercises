function solve(params) {
    let player = {
        health: 100,
        coins: 0,
    }
    let rooms = params[0].split('|').filter(x => x !== '');
    for (let index in rooms) {
        let room = rooms[index];
        let roomTokens = room.split(' ').filter(x => x !== '');
        let key = roomTokens[0];
        let value = Number(roomTokens[1]);
        if (key === 'potion') {
            let hpGain = (player.health + value) <= 100 ? value : (100 - player.health);
            player.health += hpGain;
            console.log(`You healed for ${hpGain} hp.\nCurrent health: ${player.health} hp.`)
        } else if (key === 'chest') {
            player.coins += value;
            console.log(`You found ${value} coins.`)
        } else {
            player.health -= value;
            if (player.health <= 0) {
                console.log(`You died! Killed by ${key}.\nBest room: ${Number(index) + 1}`);
                break;
            } else {
                console.log(`You slayed ${key}.`);
            }
        }
    }

    if (player.health > 0) {
        console.log(`You've made it!\nCoins: ${player.coins}\nHealth: ${player.health}`);
    }
}
solve(['rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000']);