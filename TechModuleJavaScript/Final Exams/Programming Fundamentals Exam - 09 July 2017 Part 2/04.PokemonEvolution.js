function solve(params) {
    params.pop();
    let pokemons = [];

    for (let param of params) {
        let [name, evolution, value] = param.split(' -> ');
        let pokemon = pokemons.find(p => p.name === name);

        if (param.includes(' -> ')) {
            if (!pokemon) {
                pokemons.push({ name: name, evolutions: [] });
            }

            pokemons.find(p => p.name === name).evolutions.push({ [evolution]: +value });
        } else if (pokemon) {
            console.log(`# ${name}`);

            pokemon.evolutions.forEach(e => {
                let [evolution] = Object.entries(e);
                console.log(`${evolution[0]} <-> ${evolution[1]}`);
            });
        }
    }

    for (let pokemon of pokemons) {
        console.log(`# ${pokemon.name}`);
        pokemon.evolutions.sort((a, b) => {
            return Object.values(b)[0] - Object.values(a)[0];
        }).forEach(e => {
            let [evolution] = Object.entries(e);
            console.log(`${evolution[0]} <-> ${evolution[1]}`);
        });
    }
}

solve(
    [
        'Pikachu -> Hybrid -> 100',
        'Meowth -> Physical -> 100',
        'Pikachu -> Psychological -> 50',
        'Meowth -> Physical -> 50',
        'Pikachu -> Hybrid -> 150',
        'Meowth',
        'Pikachu',
        'wubbalubbadubdub',
    ]
)