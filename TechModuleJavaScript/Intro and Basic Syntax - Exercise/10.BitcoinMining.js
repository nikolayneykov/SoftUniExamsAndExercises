function mining(arr) {
    let gold = 0;
    let bgn = 0;
    let bitcoins = 0;
    let firstBitcoinDay = 0;

    for (let i = 0; i < arr.length; i++) {
        let currentGold = Number(arr[i]);
        let day = i + 1;
        if (day % 3 === 0) {
            currentGold *= 0.70;
        }
        bgn += currentGold * 67.51;

        if (bgn >= 11949.16) {
            let currentBitcoins = Math.floor(bgn / 11949.16);
            bitcoins += currentBitcoins;
            bgn -= currentBitcoins * 11949.16;
            if (firstBitcoinDay === 0) {
                firstBitcoinDay = day;
            }
        }
    }
    console.log(`Bought bitcoins: ${bitcoins}`);
    if (bitcoins !== 0) {
        console.log(`Day of the first purchased bitcoin: ${firstBitcoinDay}`);
    }
    console.log(`Left money: ${bgn.toFixed(2)} lv.`);
}

mining(['100', '200', '300']);





