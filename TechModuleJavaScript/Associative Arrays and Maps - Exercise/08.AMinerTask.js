function printResources(params) {
    let resources = {};

    for (let i = 0; i < params.length; i += 2) {
        let resourceName = params[i];
        let quantity = Number(params[i + 1]);

        if (!resources.hasOwnProperty(resourceName)) {
            resources[resourceName] = 0;
        }
        resources[resourceName] += quantity;
    }

    for(let resource in resources){
        console.log(`${resource} -> ${resources[resource]}`);
    }
}
printResources(['Gold',
    '155',
    'Silver',
    '10',
    'Copper',
    '17'
]
);