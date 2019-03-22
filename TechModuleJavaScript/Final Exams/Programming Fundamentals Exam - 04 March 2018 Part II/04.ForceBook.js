function solve(params) {
    params.pop();
    let forceSides = {};

    for (let param of params) {
        let tokens = param.includes(' | ') ? param.split(' | ') : param.split(' -> ');
        let side = param.includes(' | ') ? tokens[0] : tokens[1];
        let user = param.includes(' | ') ? tokens[1] : tokens[0];

        if (!forceSides.hasOwnProperty(side)) {
            forceSides[side] = [];
        }

        let oldUserSide = Object.entries(forceSides).find(x => x[1].includes(user));

        if (param.includes(' | ') && !oldUserSide) {
            forceSides[side].push(user);
        } else if (param.includes(' -> ')) {
            if (oldUserSide) {
                let index = forceSides[oldUserSide[0]].indexOf(user);
                forceSides[oldUserSide[0]].splice(index, 1);
            }

            forceSides[side].push(user);
            console.log(`${user} joins the ${side} side!`);
        }
    }

    Object.entries(forceSides)
        .sort((a, b) => {
            let result = b[1].length - a[1].length;

            if (result === 0) {
                result = a[0].localeCompare(b[0]);
            }

            return result;
        })
        .forEach(s => {
            if (s[1].length > 0) {
                console.log(`Side: ${s[0]}, Members: ${s[1].length}`);

                s[1].sort((a, b) => a.localeCompare(b)).forEach(u => console.log(`! ${u}`));
            }
        });
}

solve(
    [
        'Lighter | Royal',
        'Darker | DCay',
        'Ivan Ivanov -> Lighter',
        'DCay -> Lighter',
        'Lumpawaroo'
    ]
);