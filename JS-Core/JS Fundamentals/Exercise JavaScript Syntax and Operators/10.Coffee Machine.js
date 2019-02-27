function coffeeMachine(params) {
    let incomeReport = 0;

    for (let param of params) {
        let order = param.split(', ');
        let price = 0;

        if (order.includes('decaf')) {
            price = 0.90;
        } else {
            price = 0.80;
        }

        if (order.includes('milk')) {
            price += Math.round(price * 0.1 * 10) / 10;
        }

        if (order[order.length - 1] !== '0') {
            price += 0.1;
        }

        let insertedCoins = Number(order[0]);
        let diff = Math.abs(insertedCoins - price).toFixed(2);

        if (insertedCoins >= price) {
            console.log(`You ordered ${order[1]}. Price: ${price.toFixed(2)}$ Change: ${diff}$`);
            incomeReport += price;
        } else {
            console.log(`Not enough money for ${order[1]}. Need ${diff}$ more.`);
        }
    }

    console.log(`Income Report: ${incomeReport.toFixed(2)}$`);
}

coffeeMachine(
    [
        '1.00, coffee, caffeine, milk, 4',
        '0.40, tea, milk, 2',
        '1.00, coffee, decaf, 0'
    ]
);