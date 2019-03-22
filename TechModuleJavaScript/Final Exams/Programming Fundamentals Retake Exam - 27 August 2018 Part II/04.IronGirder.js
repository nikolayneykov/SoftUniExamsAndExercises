function solve(params) {
    params.pop();
    let travels = {};

    for (let param of params) {
        let [townName, args] = param.split(':');

        if (args.startsWith('ambush')) {
            if (travels.hasOwnProperty(townName)) {
                let passengers = Number(args.split('->')[1]);
                travels[townName].totalPassengers -= passengers;
                travels[townName].bestTime = 0;
            }
        } else {
            let [time, passengers] = args.split('->');

            if (!travels.hasOwnProperty(townName)) {
                travels[townName] = { bestTime: Number(time), totalPassengers: Number(passengers) };
            } else {
                travels[townName].totalPassengers += Number(passengers);

                if (travels[townName].bestTime > Number(time) || travels[townName].bestTime === 0) {
                    travels[townName].bestTime = Number(time);
                }
            }
        }
    }


    Object.entries(travels)
        .filter(t => t[1].bestTime > 0 && t[1].totalPassengers > 0)
        .sort((a, b) => {
            let result = a[1].bestTime - b[1].bestTime;

            if (result === 0) {
                result = a[0].localeCompare(b[0]);
            }

            return result;
        })
        .forEach(t=>console.log(`${t[0]} -> Time: ${t[1].bestTime} -> Passengers: ${t[1].totalPassengers}`));

}

solve(
    ['Quirm:12->258',
        'Ankh-Morpork:ambush->200',
        'Ankh-Morpork:3->143',
        'Sto-Lat:4->80',
        'Ankh-Morpork:4->143',
        'Ankh-Morpork:ambush->143',
        'Sto-Lat:3->20',
        'Ankh-Morpork:5->17',
        'Slide rule']

);