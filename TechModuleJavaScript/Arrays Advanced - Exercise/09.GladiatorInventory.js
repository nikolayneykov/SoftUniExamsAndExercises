function printInventory(params) {
    let inventory = params[0].split(' ');

    for (let i = 1; i < params.length; i++) {
        let tokens = params[i].split(/[-\s]+/);
        let command = tokens[0];
        let equipment = tokens[1];
        let index = inventory.indexOf(equipment);

        if (command === 'Buy' && index === -1) {
            inventory.push(equipment);
        } else if (command === 'Trash' && index !== -1) {
            inventory.splice(index, 1);
        } else if (command === 'Repair' && index !== -1) {
            inventory.push(inventory.splice(index, 1));
        } else if (command === 'Upgrade' && index !== -1) {
            let upgrade = tokens[2];
            let upgradedEquipment = equipment + ':' + upgrade;
            inventory.splice(index+1,0,upgradedEquipment);
        }
    }

    console.log(inventory.join(' '));
}
printInventory([
    'SWORD Shield Spear',
    'Buy Bag',
    'Trash Shield',
    'Repair Spear',
    'Upgrade SWORD-Steel',
]);