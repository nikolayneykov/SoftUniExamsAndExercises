function printDungeon(params) {
    let rooms = params[0].split('|');
    let health = 100;
    let coins = 0;

    for (let i = 0; i < rooms.length; i++) {
        let room = rooms[i].split(' ');
        let roomContent = room[0];
        let roomValue = Number(room[1]);

        if (roomContent === 'potion') {
            let healthGain = Math.min(roomValue, 100 - health);
            health += healthGain;
            console.log(`You healed for ${healthGain} hp.\nCurrent health: ${health} hp.`);
        } else if (roomContent === 'chest') {
            coins += roomValue;
            console.log(`You found ${roomValue} coins.`);
        } else {
            let monsterName = roomContent;
            let monsterDamage = roomValue;
            health -= monsterDamage;
            if (health <= 0) {
                console.log(`You died! Killed by ${monsterName}.\nBest room: ${i + 1}`);
                break;
            }
            console.log(`You slayed ${monsterName}.`);
        }
    }

    if (health > 0) {
        console.log(`You've made it!\nCoins: ${coins}\nHealth: ${health}`);
    }
}
printDungeon(['cat 10|potion 30|orc 10|chest 10|snake 25|chest 110']);
//printDungeon(['rat 10|bat 20|potion 10|rat 10|chest 100|boss 70|chest 1000']);