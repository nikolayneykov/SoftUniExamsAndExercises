function printPyramidDetails(baseSize, increment) {
    let stone = 0;
    let marble = 0;
    let lapis = 0;
    let gold = 0;
    let pyramidHeight = 0;
    let blocks = baseSize * baseSize;
    let steps = 1;
    while (blocks !== 1 && blocks !== 4) {
        let innerBlocks = (baseSize - 2) * (baseSize - 2);
        let outerBlocks = blocks - innerBlocks;
        stone += innerBlocks * increment;

        if (steps % 5 !== 0) {
            marble += outerBlocks * increment;
        } else {
            lapis += outerBlocks * increment;
        }

        steps++;
        blocks = innerBlocks;
        baseSize -= 2;
    }

    gold += blocks * increment;
    pyramidHeight = steps * increment;

    console.log(`Stone required: ${Math.ceil(stone)}`);
    console.log(`Marble required: ${Math.ceil(marble)}`);
    console.log(`Lapis Lazuli required: ${Math.ceil(lapis)}`);
    console.log(`Gold required: ${Math.ceil(gold)}`);
    console.log(`Final pyramid height: ${Math.floor(pyramidHeight)}`);
}

printPyramidDetails(11,0.75);


// Stone required: 124
// Marble required: 84
// Lapis Lazuli required: 6
// Gold required: 1
// Final pyramid height: 4







