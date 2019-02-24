function printChristmasData(params) {
    let quanitity = Number(params[0]);
    let maxDays = Number(params[1]);
    let ornamentSet = 2;
    let treeSkirt = 5;
    let treeGarlands = 3;
    let treeLights = 15;
    let budget = 0;
    let totalSpirit = 0;

    for (let day = 1; day <= maxDays; day++) {
        if (day % 10 === 0) {
            totalSpirit -= 20;
            budget += treeSkirt + treeGarlands + treeLights;
            if (day === maxDays) {
                totalSpirit -= 30;
            }
        }
        if (day % 11 === 0) {
            quanitity += 2;
        }

        if (day % 2 === 0) {
            budget += quanitity * ornamentSet;
            totalSpirit += 5;
        }
        if (day % 3 === 0) {
            budget += quanitity * (treeSkirt + treeGarlands);
            totalSpirit += 13;
        }
        if (day % 5 === 0) {
            budget += quanitity * treeLights;
            totalSpirit += 17;
            if (day % 3 === 0) {
                totalSpirit += 30;
            }
        }
    }
    console.log(`Total cost: ${budget}\nTotal spirit: ${totalSpirit}`);
}
printChristmasData(['3', '20']);

