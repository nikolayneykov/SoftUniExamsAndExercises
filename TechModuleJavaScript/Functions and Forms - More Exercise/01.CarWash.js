function solve(params) {
    let value = 0;

    for (let p of params) {
        switch (p) {
            case 'soap': value += 10; break;
            case 'water': value *= 1.2; break;
            case 'vacuum cleaner': value *= 1.25; break;
            case 'mud': value *= 0.9; break;
        }
    }
    return `The car is ${value.toFixed(2)}% clean.`;
}
console.log(solve(['soap', 'soap', 'vacuum cleaner', 'mud', 'soap', 'water']));

/*
•	soap – add 10 to the value
•	water – increase the value with 20%
•	vacuum cleaner – increase the value with 25%
•	mud – decrease the value with 10%

*/