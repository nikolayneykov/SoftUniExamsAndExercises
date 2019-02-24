function solve(coordinates) {
    let pointA = { x: coordinates[0], y: coordinates[1] };
    let pointB = { x: coordinates[2], y: coordinates[3] };
    let pointC = { x: 0, y: 0 };

    let aToCDistance = Math.sqrt(Math.pow(pointA.x - pointC.x, 2) + Math.pow(pointA.y - pointC.y, 2));
    let bToCDistance = Math.sqrt(Math.pow(pointB.x - pointC.x, 2) + Math.pow(pointB.y - pointC.y, 2));
    let aToBDistance = Math.sqrt(Math.pow(pointA.x - pointB.x, 2) + Math.pow(pointA.y - pointB.y, 2));

    let aToCResult = Number.isInteger(aToCDistance) ? 'valid' : 'invalid';
    let bToCResult = Number.isInteger(bToCDistance) ? 'valid' : 'invalid';
    let aToBResult = Number.isInteger(aToBDistance) ? 'valid' : 'invalid';

    console.log(`{${pointA.x}, ${pointA.y}} to {${pointC.x}, ${pointC.y}} is ${aToCResult}`);
    console.log(`{${pointB.x}, ${pointB.y}} to {${pointC.x}, ${pointC.y}} is ${bToCResult}`);
    console.log(`{${pointA.x}, ${pointA.y}} to {${pointB.x}, ${pointB.y}} is ${aToBResult}`);
}
solve([2, 1, 1, 1]);