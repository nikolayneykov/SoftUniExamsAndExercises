function calculateRadius(radius) {
    let typeOfInput = typeof radius;

    if (typeof radius !== 'number') {
        console.log(`We can not calculate the circle area, because we receive a ${typeOfInput}.`);
    } else {
        console.log((radius * radius * Math.PI).toFixed(2))
    }
}

calculateRadius('5');
calculateRadius(5);