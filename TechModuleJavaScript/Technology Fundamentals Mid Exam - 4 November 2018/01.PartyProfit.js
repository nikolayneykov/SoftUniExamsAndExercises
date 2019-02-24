// function solve(params) {
//     let party = {
//         companions: params[0],
//         coins: 0
//     };

//     for (let day = 1; day <= params[1]; day++) {
//         if (day % 10 === 0) {
//             party.companions -= 2;
//         }
//         if (day % 15 === 0) {
//             party.companions += 5;
//         }
//         party.coins += 50;
//         party.coins -= 2 * party.companions;
//         if (day % 3 === 0) {
//             party.coins -= 3 * party.companions;
//         }
//         if (day % 5 === 0) {
//             party.coins += 20 * party.companions;
//             if (day % 3 === 0) {
//                 party.coins -= 2 * party.companions;
//             }
//         }
//     }
//     console.log(`${party.companions} companions received ${Math.floor(party.coins / party.companions)} coins each.`);
// }

// solve([15, 30]);

function party(args) {
    args.join(' ').split(' ');
    let companionsCount = +args[0];
    let totalCoins = 0;
    let days = +args[1];

    for (let i = 1; i <= +days; i++) {
        if (i % 10 === 0) {
            companionsCount -= 2;
        }
        if (i % 15 === 0) {
            companionsCount += 5;
        }
        totalCoins += (50 - (companionsCount * 2));

        if (i % 3 === 0) {
            totalCoins -= (companionsCount * 3);
        }
        if (i % 5 === 0) {
            totalCoins += (companionsCount * 20);
        }
        if (i % 3 === 0 && i % 5 === 0) {
            totalCoins -= (companionsCount * 2);
        }
    }

    let coins = Math.floor(totalCoins / companionsCount);
    console.log(`${+companionsCount} companions received ${+coins} coins each.`);
}
party(3, 5);