function convertCoins(amount, coins) {
    let convertedCoins = [];
    let sortedCoins = coins.sort((a, b) => b - a);

    for (let coin of sortedCoins) {
        while (amount - coin >= 0) {
            convertedCoins.push(coin);
            amount -= coin;
        }
    }

    console.log(convertedCoins.join(', '));
}

convertCoins(46, [10, 25, 5, 1, 2]); 