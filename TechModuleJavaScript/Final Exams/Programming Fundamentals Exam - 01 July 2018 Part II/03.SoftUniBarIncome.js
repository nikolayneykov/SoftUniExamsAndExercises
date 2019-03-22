function solve(params) {
    params.pop();
    let totalIncome = 0;
    let regex = /%([A-Z][a-z]+)%[^|$%.]*?<(\w+)>[^|$%.]*?\|(\d+)\|[^|$%.]*?(\d+(\.\d+)?)\$/;

    for (let param of params) {
        let match = param.match(regex);

        if (match) {
            let name = match[1];
            let product = match[2];
            let count = Number(match[3]);
            let price = Number(match[4]);
            let currentIncome = count * price;
            totalIncome += currentIncome;
            console.log(`${name}: ${product} - ${currentIncome.toFixed(2)}`);
        }
    }

    console.log(`Total income: ${totalIncome.toFixed(2)}`);
}
solve(
    ['%George%<Croissant>|2|10.3$',
        '%Peter%<Gum>|1|1.3$',
        '%Maria%<Cola>|1|2.4$',
        'end of shift']

);