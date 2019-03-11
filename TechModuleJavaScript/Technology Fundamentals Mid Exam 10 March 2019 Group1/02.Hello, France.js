function solve(params) {
    const clothesMaxPrice = 50;
    const shoesMaxPrice = 35;
    const accessoriesMaxPrice = 20.5;

    let items = params[0].split('|').map(x => x.split('->'));
    let budget = Number(params[1]);
    let boughtItemPrices = [];

    for (let item of items) {
        let type = item[0];
        let price = Number(item[1]);

        if ((type === 'Clothes' && price <= clothesMaxPrice && budget - price >= 0) ||
            (type === 'Shoes' && price <= shoesMaxPrice && budget - price >= 0) ||
            (type === 'Accessories' && price <= accessoriesMaxPrice && budget - price >= 0)) {
            budget -= price;
            boughtItemPrices.push(price);
        }
    }

    let oldSum = boughtItemPrices.reduce((a, b) => a + b, 0);
    boughtItemPrices.forEach((e, i) => boughtItemPrices[i] *= 1.4);
    let newSum = boughtItemPrices.reduce((a, b) => a + b, 0);
    let profit = newSum - oldSum;

    console.log(boughtItemPrices.map(x => x.toFixed(2)).join(' '));
    console.log(`Profit: ${profit.toFixed(2)}`);
    console.log(budget + newSum >= 150 ? 'Hello, France!' : 'Time to go.');
}

solve([
    'Clothes->43.30|Shoes->25.25|Clothes->36.52|Clothes->20.90|Accessories->15.60',
    '120',
]);