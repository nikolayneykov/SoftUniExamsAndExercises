function printBestDna(params) {
    let bestDna = [];
    let bestSample = 0;
    let bestSum = 0;
    let bestSequenceLength = 0;
    let bestSequenceIndex = Number.MAX_SAFE_INTEGER;

    for (let i = 1; i < params.length; i++) {
        let currentDna = params[i].split('!').filter(e => e !== '').join('');
        let currentSample = i;
        let currentSum = currentDna.split('').filter(e => e === '1').length;
        let bestSequence = currentDna.split('0').sort((a, b) => b.length - a.length)[0];
        let currentIndex = currentDna.indexOf(bestSequence);
        let foundBetterDna = false;
        
        if (bestSequenceLength < bestSequence.length) {
            foundBetterDna = true;
        } else if (bestSequenceLength === bestSequence.length &&
            bestSequenceIndex > currentIndex) {
            foundBetterDna = true;
        } else if (bestSequenceLength === bestSequence.length &&
            bestSequenceIndex === currentIndex &&
            bestSum < currentSum) {
            foundBetterDna = true;
        }

        if (foundBetterDna) {
            bestDna = currentDna.split('').join(' ');
            bestSample = currentSample;
            bestSum = currentSum;
            bestSequenceLength = bestSequence.length;
            bestSequenceIndex = currentIndex;
        }
    }

    console.log(`Best DNA sample ${bestSample} with sum: ${bestSum}.\n${bestDna}`);
}
printBestDna([5,
    '1!0!1!1!0',
    '0!1!1!0!0']
);