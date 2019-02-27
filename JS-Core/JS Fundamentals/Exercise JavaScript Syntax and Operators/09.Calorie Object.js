function printObject(params) {
    let caloriesData = {};

    for (let i = 0; i < params.length; i += 2) {
        let product = params[i];
        let calories = Number(params[i + 1]);

        caloriesData[product] = calories;
    }

    console.log(caloriesData);
}

printObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);