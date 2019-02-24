function solve(params) {
    let leaders = {};

    for (let p of params) {
        if (p.includes(' arrives')) {
            let leader = p.replace(' arrives', '');
            if (leaders[leader] === undefined) {
                leaders[leader] = {};
            }
        } else if (p.includes(':')) {
            let tokens = p.split(': ');
            let leader = tokens[0];
            let army = tokens[1].split(', ')[0];
            let count = Number(tokens[1].split(', ')[1]);
            if (leaders[leader] !== undefined) {
                leaders[leader][army] = count;
            }
        } else if (p.includes(' + ')) {
            let tokens = p.split(' + ');
            let army = tokens[0];
            let count = Number(tokens[1]);
            for (let leader in leaders) {
                if (leaders[leader][army] !== undefined) {
                    leaders[leader][army] += count;
                }
            }
        } else if (p.includes(' defeated')) {
            let leader = p.replace(' defeated', '');
            delete leaders[leader];
        }
    }

    for (let leader in leaders) {
        leaders[leader]['totalCount'] = 0;

        for (let army in leaders[leader]) {
            if (army !== 'totalCount') {
                leaders[leader]['totalCount'] += leaders[leader][army];
            }
        }
    }
    let sortedLeaders = Object.keys(leaders).sort((a, b) => leaders[b]['totalCount'] - leaders[a]['totalCount']);

    for (let leader of sortedLeaders) {
        console.log(`${leader}: ${leaders[leader].totalCount}`);
        let sortedArmy = Object.keys(leaders[leader]).filter(x => x !== 'totalCount').sort((a, b) => leaders[leader][b] - leaders[leader][a]);
        for (let army of sortedArmy) {
            console.log(`>>> ${army} - ${leaders[leader][army]}`)
        }
    }
}
solve(['Rick Burr arrives', 'Fergus: Wexamp, 30245', 'Rick Burr: Juard, 50000', 'Findlay arrives', 'Findlay: Britox, 34540', 'Wexamp + 6000', 'Juard + 1350', 'Britox + 4500', 'Porter arrives', 'Porter: Legion, 55000', 'Legion + 302', 'Rick Burr defeated', 'Porter: Retix, 3205']);