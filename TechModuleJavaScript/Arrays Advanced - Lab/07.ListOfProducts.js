function listProducts(arr) {
    let result = arr.sort();
    for (let i = 0; i < result.length; i++) {
        result[i] = i + 1 + '.' + result[i];
    }
    console.log(result.join('\n'));
}
listProducts(["Potatoes", "Tomatoes", "Onions", "Apples"]);