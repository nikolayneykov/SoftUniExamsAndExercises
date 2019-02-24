function printTowns(params) {
    let towns = [];

    for (let i = 1; i < params.length; i++) {
        let tokens = params[i].split('|').filter(x => x !== '');
        let townName = tokens[0].trim(' ');
        let townLatitude = +((+tokens[1]).toFixed(2));
        let townLongitude = +((+tokens[2]).toFixed(2));

        towns.push({
            Town: townName,
            Latitude: townLatitude,
            Longitude: townLongitude
        });
    }

    console.log(JSON.stringify(towns));
}
printTowns(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |']
)