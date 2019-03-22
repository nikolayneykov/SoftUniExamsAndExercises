function solve(params) {
    let games = {};
    let tokens = params[0].split(', ');

    for (let token of tokens) {
        if (token.includes('-')) {
            let [name, price] = token.split('-');
            games[name] = {
                'price': Number(price)
            };
        } else if (token.includes(':')) {
            let [name, dlc] = token.split(':');
            if (games.hasOwnProperty(name)) {
                games[name].dlc = dlc;
                games[name].price *= 1.2;
            }
        }
    }

    for (let game in games) {
        if (games[game].hasOwnProperty('dlc')) {
            games[game].price *= 0.5;
        } else {
            games[game].price *= 0.8;
        }
    }

    Object.entries(games)
        .filter(g => g[1].dlc)
        .sort((a, b) => a[1].price - b[1].price)
        .forEach(g => console.log(`${g[0]} - ${g[1].dlc} - ${g[1].price.toFixed(2)}`));

    Object.entries(games)
        .filter(g => !g[1].dlc)
        .sort((a, b) => b[1].price - a[1].price)
        .forEach(g => console.log(`${g[0]} - ${g[1].price.toFixed(2)}`));
}

solve(
    [
        'WitHer 3-50, FullLife 3-60, WitHer 3:Blood and Beer, Cyberfunk 2077-120, League of Leg Ends-10, League of Leg Ends:DoaT'
    ]
)