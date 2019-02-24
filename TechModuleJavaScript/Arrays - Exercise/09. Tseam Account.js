function printTseamAccount(params) {
    let account = params.shift().split(' ');
    params.pop();
    for (let param of params) {
        let tokens = param.split(' ');
        let command = tokens[0];
        let game = tokens[1].split('-')[0];
        let index = account.indexOf(game);

        if (command === 'Install' && index === -1) {
            account.push(game);
        } else if (command === 'Uninstall' && index !== -1) {
            account.splice(index, 1);
        } else if (command === 'Update' && index !== -1) {
            account.push(account.splice(index, 1));
        } else if (command === 'Expansion' && index !== -1) {
            let expansion = tokens[1].replace('-', ':');
            account.splice(index + 1, 0, expansion);
        }
    }
    console.log(account.join(' '));
}

printTseamAccount(['CS WoW Diablo',
    'Install LoL',
    'Uninstall WoW',
    'Update Diablo',
    'Expansion CS-Go',
    'Play!',]
);