function solve(params) {
    params.pop();
    let data = {};
    let cache = {};

    for (let param of params) {
        if (!param.includes(' -> ')) {
            let dataSet = param;

            if (!data.hasOwnProperty(dataSet)) {
                data[dataSet] = {};
            }

            if (cache.hasOwnProperty(dataSet)) {
                for (let key in cache[dataSet]) {
                    data[dataSet][key] = cache[dataSet][key];
                }

                delete cache[dataSet];
            }
        } else {
            let [dataKey, dataSize, dataSet] = param.split(/[\s\->|]+/g);

            if (data.hasOwnProperty(dataSet)) {
                data[dataSet][dataKey] = +dataSize;
            } else {
                if (!cache.hasOwnProperty(dataSet)) {
                    cache[dataSet] = {};
                }

                cache[dataSet][dataKey] = +dataSize;
            }

        }
    }

    let bestDataSet = Object.entries(data)
        .sort((a, b) => {
            let aSum = Object.values(a[1]).reduce((d1, d2) => d1 + d2, 0);
            let bSum = Object.values(b[1]).reduce((d1, d2) => d1 + d2, 0);
            return bSum - aSum;
        })[0];

    let dataSize = Object.values(bestDataSet[1]).reduce((a, b) => a + b, 0);

    if (dataSize > 0) {
        console.log(`Data Set: ${bestDataSet[0]}, Total Size: ${dataSize}`);

        for(let dataKey in bestDataSet[1]){
            console.log(`$.${dataKey}`);
        }
    }
}

solve(
    [
        'Cars',
        'Car1 -> 233333 | Cars',
        'Car23 -> 266666 | Cars',
        'Warehouse2 -> 10000 | Buildings',
        'Warehouse3 -> 480000 | Buildings',
        'Warehouse5 -> 100000 | Buildings',
        'Buildings',
        'thetinggoesskrra',
    ]

)