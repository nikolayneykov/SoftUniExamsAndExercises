function calculateExpenses(lostFightCount, helmentPrice, swordPrice, shieldPrice, armorPrice) {
    let totalExpenses = 0;
    let shieldCnt = 0;
    for (let i = 1; i <= lostFightCount; i++) {
        let currentExpenses = 0;
        if (i % 2 == 0 && i % 3 == 0) {
            currentExpenses += helmentPrice + swordPrice + shieldPrice;
            shieldCnt++;
        } else if (i % 2 == 0) {
            currentExpenses += helmentPrice;
        } else if (i % 3 == 0) {
            currentExpenses += swordPrice;
        }
        if (shieldCnt == 2) {
            currentExpenses += armorPrice;
            shieldCnt = 0;
        }
        totalExpenses += currentExpenses;
    }
    console.log(`Gladiator expenses: ${totalExpenses.toFixed(2)} aureus`);
}