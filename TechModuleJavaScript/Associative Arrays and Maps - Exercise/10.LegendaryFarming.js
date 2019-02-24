function farmItem(params) {
    let arr = params.split(' ');
    let keyMaterials = { fragments: 0, shards: 0, motes: 0 };
    let junkMaterials = {};
    let obtainedItem = '';

    for (let i = 0; i < arr.length; i += 2) {
        let quantity = Number(arr[i]);
        let material = arr[i + 1].toLowerCase();

        if (material === 'fragments' || material === 'shards' || material === 'motes') {
            keyMaterials[material] += quantity;
        } else {
            if (!junkMaterials.hasOwnProperty(material)) {
                junkMaterials[material] = 0;
            }
            junkMaterials[material] += quantity;
        }

        if (keyMaterials.shards >= 250) {
            obtainedItem = 'Shadowmourne';
            keyMaterials.shards -= 250;
            break;
        } else if (keyMaterials.fragments >= 250) {
            obtainedItem = 'Valanyr';
            keyMaterials.fragments -= 250;
            break;
        } else if (keyMaterials.motes >= 250) {
            obtainedItem = 'Dragonwrath';
            keyMaterials.motes -= 250;
            break;
        }
    }
    console.log(`${obtainedItem} obtained!`);

    let sortedKeyMaterials = Object.entries(keyMaterials)
        .sort(function (a, b) {
            let result = b[1] - a[1];
            if (result === 0) {
                result = a[0].localeCompare(b[0]);
            }
            return result;
        });

    for (let [material, quantity] of sortedKeyMaterials) {
        console.log(`${material}: ${quantity}`);
    }

    let sortedJunkMaterials = Object.entries(junkMaterials)
        .sort((a, b) => a[0].localeCompare(b[0]));

    for (let [material, quantity] of sortedJunkMaterials) {
        console.log(`${material}: ${quantity}`);
    }
}
farmItem('3 Motes 5 stones 5 Shards 6 leathers 255 fragments 7 Shards');
