function solve(params) {
    let budget = params[0];
    let students = params[1];
    let priceOfFlour = params[2];
    let priceOfEgg = params[3];
    let priceOfApron = params[4];
    let freePackeges = Math.floor(students / 5);
    let cost = (priceOfFlour * (students - freePackeges)) +
        (priceOfEgg * 10 * students) +
        ((priceOfApron * Math.ceil(students * 1.2)));
    console.log(budget >= cost ?
        `Items purchased for ${cost.toFixed(2)}$.` :
        `${(cost - budget).toFixed(2)}$ more needed.`);
}
solve([100,
    25,
    4.0,
    1.0,
    6.0]
);