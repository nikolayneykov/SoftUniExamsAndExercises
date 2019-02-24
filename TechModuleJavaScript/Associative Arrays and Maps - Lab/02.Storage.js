function printStorage(params) {
    let storage = new Map();

    for (let param of params) {
        let tokens = param.split(' ');
        let product = tokens[0];
        let quantity = Number(tokens[1]);
        if (storage.has(product)) {
            quantity += storage.get(product);
        }

        storage.set(product, quantity);
    }
    
    for(let [product,quantity] of storage){
        console.log(`${product} -> ${quantity}`);
    }
}
printStorage(['tomatoes 10',
    'coffee 5',
    'olives 100',
    'coffee 40']
);