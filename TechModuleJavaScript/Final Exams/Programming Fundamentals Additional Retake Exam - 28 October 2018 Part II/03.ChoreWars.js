function solve(params) {
    params.pop();
    let [timeDishes, timeCleaning, timeLaundry] = [0, 0, 0];
    let [regDishes, regCleaning, regLaundy] = [/<[a-z\d]+>/, /\[[A-Z\d]+\]/, /\{.+\}/];

    for (let param of params) {
        if (param.match(regDishes)) {
            timeDishes += sumDigits(param.match(regDishes)[0]);
        } else if (param.match(regCleaning)) {
            timeCleaning += sumDigits(param.match(regCleaning)[0]);
        } else if (param.match(regLaundy)) {
            timeLaundry += sumDigits(param.match(regLaundy)[0]);
        }
    }

    console.log(`Doing the dishes - ${timeDishes} min.`);
    console.log(`Cleaning the house - ${timeCleaning} min.`);
    console.log(`Doing the laundry - ${timeLaundry} min.`);
    console.log(`Total - ${timeDishes+timeCleaning+timeLaundry} min.`);

    function sumDigits(str) {
        return str.split('')
            .filter(c => Number.isInteger(+c))
            .map(Number)
            .reduce((a, b) => a + b, 0);
    }
}

solve(
    ['-^hr5a65j48<dd6f5h4dhfd>456sga_+',
        'DHdhy4*3[T2HOU87KRC]sA/@',
        'Sda%t]gf{%hjK8f34)!fG1re}-+htG%v',
        'wife is happy',]
)