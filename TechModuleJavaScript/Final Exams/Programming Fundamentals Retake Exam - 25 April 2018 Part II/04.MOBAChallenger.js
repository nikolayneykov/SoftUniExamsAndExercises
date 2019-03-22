function solve(params) {
    params.pop();
    let players = {};

    for (let param of params) {
        if (param.includes(' -> ')) {
            let [player, position, skill] = param.split(' -> ');

            if (!players.hasOwnProperty(player)) {
                players[player] = {
                    positions: {},
                    getTotalSkill() {
                        return Object.values(this.positions).reduce((a, b) => a + b, 0);
                    },
                    hasCommonPosition(otherPositions) {
                        let result = false;

                        for (let p1 in this.positions) {
                            if (otherPositions.hasOwnProperty(p1)) {
                                result = true;
                                break;
                            }
                        }

                        return result;
                    }
                }
            }

            if (!players[player].positions.hasOwnProperty(position) ||
                players[player].positions[position] < +skill) {
                players[player].positions[position] = +skill;
            }
        } else if (param.includes(' vs ')) {
            let [player1, player2] = param.split(' vs ');

            if (players.hasOwnProperty(player1) &&
                players.hasOwnProperty(player2) &&
                players[player1].hasCommonPosition(players[player2].positions)) {

                if (players[player1].getTotalSkill() > players[player2].getTotalSkill()) {
                    delete players[player2];
                } else if (players[player1].getTotalSkill() < players[player2].getTotalSkill()) {
                    delete players[player1];
                }
            }
        }
    }

    Object.entries(players)
        .sort((a, b) => b[1].getTotalSkill() - a[1].getTotalSkill())
        .forEach(player => {
            console.log(`${player[0]}: ${player[1].getTotalSkill()} skill`);
            Object.entries(player[1].positions)
                .sort((a,b)=>b[1]-a[1])
                .forEach(position=>console.log(`- ${position[0]} <::> ${position[1]}`));
        });
}

solve(
    ['Pesho -> Adc -> 400',
        'Bush -> Tank -> 150',
        'Faker -> Mid -> 200',
        'Faker -> Support -> 250',
        'Faker -> Tank -> 250',
        'Pesho vs Faker',
        'Faker vs Bush',
        'Faker vs Hide',
        'Season end']
)