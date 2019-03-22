function solve(params) {
    let bands = {};
    let totalTime = 0;

    for (let param of params) {
        if (param === 'start of concert') {
            break;
        }

        let [command, bandName, args] = param.split('; ');

        if (!bands.hasOwnProperty(bandName)) {
            bands[bandName] = {
                time: 0,
                members: new Set()
            };
        }

        if (command === 'Add') {
            let members = args.split(', ');
            members.forEach(m => bands[bandName].members.add(m));
        } else if (command === 'Play') {
            let time = Number(args);
            totalTime += time;
            bands[bandName].time += time;
        }

    }

    console.log(`Total time: ${totalTime}`);

    Object.entries(bands).sort(function (a, b) {
        let result = b[1].time - a[1].time;

        if (result === 0) {
            result = a[0].localeCompare(b[0]);
        }

        return result;
    }).forEach(band => console.log(`${band[0]} -> ${band[1].time}`));

    let bandName = params[params.length-1];
    console.log(bandName);
    bands[bandName].members.forEach(m=>console.log(`=> ${m}`));
}

solve(
    [
        'Play; The Beatles; 2584',
        'Add; The Beatles; John Lennon, Paul McCartney, George Harrison, Ringo Starr',
        'Add; Eagles; Glenn Frey, Don Henley, Bernie Leadon, Randy Meisner',
        'Play; Eagles; 1869',
        'Add; The Rolling Stones; Brian Jones, Mick Jagger, Keith Richards',
        'Add; The Rolling Stones; Brian Jones, Mick Jagger, Keith Richards, Bill Wyman, Charlie Watts, Ian Stewart',
        'Play; The Rolling Stones; 4239',
        'start of concert',
        'The Rolling Stones'
    ]

)