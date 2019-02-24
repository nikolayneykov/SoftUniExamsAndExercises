function printNeighborhoods(params) {
    let neighborhoods = {};
    let neighborhoodNames = params.shift().split(', ').filter(x => x !== '');
    for (let neighborhood of neighborhoodNames) {
        neighborhoods[neighborhood] = [];
    }

    for (let param of params) {
        let tokens = param.split(' - ');
        let neighborhood = tokens[0];
        let person = tokens[1];

        if (neighborhoods.hasOwnProperty(neighborhood)) {
            neighborhoods[neighborhood].push(person);
        }
    }

    let sortedNeighborhoods = Object.entries(neighborhoods)
        .sort((a, b) => b[1].length - a[1].length);

    for (let neighborhood of sortedNeighborhoods) {
        console.log(`${neighborhood[0]}: ${neighborhood[1].length}`);
        for (let person of neighborhood[1]) {
            console.log(`--${person}`);
        }
    }
}
printNeighborhoods(['Abbey Street, Herald Street, Bright Mews',
    'Bright Mews - Garry',
    'Bright Mews - Andrea',
    'Invalid Street - Tommy',
    'Abbey Street - Billy']
);