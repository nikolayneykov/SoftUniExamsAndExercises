function solve(params) {
    params.pop();
    let games = params.shift().split(' ');

    for (let param of params) {
        let [command, game, expansion] = param.split(/\s|-/);
        let index = games.indexOf(game);

        if (command === 'Install' && index === -1) {
            games.push(game);
        } else if (command === 'Uninstall' && index !== -1) {
            games.splice(index, 1);
        } else if (command === 'Update' && index !== -1) {
            games.push(...games.splice(index, 1));
        } else if (command === 'Expansion' && index !== -1){
            games.splice(index+1,0,game+':'+expansion);
        }
    }

    console.log(games.join(' '));
}

solve(
    ['CS WoW Diablo',
        'Install LoL',
        'Uninstall WoW',
        'Update Diablo',
        'Expansion CS-Go',
        'Play!']
)