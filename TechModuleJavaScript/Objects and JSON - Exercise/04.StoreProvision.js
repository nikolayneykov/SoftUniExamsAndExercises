function storeProvision(params) {
    let products = {};

    for (let i = 0; i < params.length; i++) {
        for (let j = 0; j < params[i].length; j += 2) {
            let product = params[i][j];
            let quantity = Number(params[i][j + 1]);

            if (!products.hasOwnProperty(product)) {
                products[product] = 0;
            }
            products[product] += quantity;
        }
    }
    console.log(products);
}
storeProvision([
    ['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],
    ['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30']
]);