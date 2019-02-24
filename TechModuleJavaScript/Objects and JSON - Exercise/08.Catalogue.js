function printCatalogue(params) {
    let catalogue = {};
    for (let param of params) {
        let tokens = param.split(' : ').filter(x => x !== '');
        let product = tokens[0];
        let price = tokens[1];
        catalogue[product] = price;
    }
    let sortedCatalogue = Object.entries(catalogue).sort((a, b) => a[0].localeCompare(b[0]));
    let firstLetter = '';

    for (let product of sortedCatalogue) {
        if (firstLetter !== product[0][0]) {
            firstLetter = product[0][0];
            console.log(firstLetter);
        }
        console.log(`  ${product[0]}: ${product[1]}`);
    }
}
printCatalogue([
    'Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10',
])