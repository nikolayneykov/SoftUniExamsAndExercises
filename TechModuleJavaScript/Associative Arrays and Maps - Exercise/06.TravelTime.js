function printDestinations(params) {
    let countries = {};

    for (let param of params) {
        let tokens = param.split(' > ');
        let country = tokens[0];
        let town = tokens[1];
        let price = Number(tokens[2]);

        if (!countries.hasOwnProperty(country)) {
            countries[country] = {};
        }
        if (!countries[country].hasOwnProperty(town)) {
            countries[country][town] = price;
        }
        if (countries[country][town] > price) {
            countries[country][town] = price;
        }
    }

    let sortedCountries = Object.entries(countries)
        .sort((a, b) => a[0].localeCompare(b[0]));

    for (let [country, town] of sortedCountries) {
        let sortedTowns = Object.entries(town)
            .sort((a, b) => a[1] - b[1])
            .map(t=>t.join(' -> '));
        console.log(`${country} -> ${sortedTowns.join(' ')}`);
    }
}
printDestinations(['Bulgaria > Sofia > 25000',
    'Bulgaria > Sofia > 2500',
    'Kalimdor > Orgrimar > 25000',
    'Albania > Tirana > 25000',
    'Bulgaria > Aarna > 25010',
    'Bulgaria > Lukovit > 10',]
);