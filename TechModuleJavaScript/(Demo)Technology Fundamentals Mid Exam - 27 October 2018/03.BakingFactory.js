function solve(params) {
    let batches = [];
    for (let p of params) {
        if (p === 'Bake It!') {
            break;
        }
        let currentBatch = p.split('#').filter(x => x !== '').map(Number);
        batches.push(currentBatch);
    }
    batches.sort(function (a, b) {
        let aSum = a.reduce((c, d) => c + d, 0);
        let bSum = b.reduce((c, d) => c + d, 0);
        let result = bSum - aSum;
        if (result === 0) {
            result = (bSum / b.length) - (aSum / a.length);
            if (result === 0) {
                result = a.length - b.length;
            }
        }
        return result;
    });
    let bestBatch = batches[0];
    let quality = bestBatch.reduce((a, b) => a + b, 0);
    console.log(`Best Batch quality: ${quality}\n${bestBatch.join(' ')}`)
}
solve(['5#4#10#-2',
    '10#5#2#3#2',
    'Bake It!',
]);