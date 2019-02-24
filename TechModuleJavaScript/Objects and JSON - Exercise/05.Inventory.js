function registerHeroes(params) {
    let heroes = [];

    for (let param of params) {
        let tokens = param.split(' / ').filter(x => x !== '');
        let name = tokens[0];
        let level = Number(tokens[1]);
        let items = tokens[2].split(', ').filter(x => x !== '');
        heroes.push({
            name, level, items
        });
    }
    console.log(JSON.stringify(heroes));
}
registerHeroes(["Isacc / 25 / Apple, GravityGun",
    "Derek / 12 / BarrelVest, DestructionSword",
    "Hes / 1 / Desolator, Sentinel, Antara"]
);