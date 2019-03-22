function solve(params) {
    params.pop();
    let usernames = {};
    let submissions = {};

    for (let param of params) {
        let [username, ...args] = param.split('-');

        if (args[0] === 'banned') {
            if (usernames.hasOwnProperty(username)) {
                delete usernames[username];
            }
        } else {
            let language = args[0];
            let points = Number(args[1]);

            if (!usernames.hasOwnProperty(username) || usernames[username] < points) {
                usernames[username] = points;
            }

            if (!submissions.hasOwnProperty(language)) {
                submissions[language] = 0;
            }

            submissions[language]++;
        }
    }

    console.log('Results:');
    Object.entries(usernames)
        .sort(orderByDescending)
        .forEach(x => console.log(`${x[0]} | ${x[1]}`));

    console.log('Submissions:');
    Object.entries(submissions)
        .sort(orderByDescending)
        .forEach(x => console.log(`${x[0]} - ${x[1]}`));

    function orderByDescending(a, b) {
        let result = b[1] - a[1];

        if (result === 0) {
            result = a[0].localeCompare(b[0]);
        }

        return result;
    }
}

solve(
    ['Pesho-Java-91',
        'Gosho-C#-84',
        'Kiro-JavaScript-90',
        'Kiro-C#-50',
        'Kiro-banned',
        'exam finished']
)