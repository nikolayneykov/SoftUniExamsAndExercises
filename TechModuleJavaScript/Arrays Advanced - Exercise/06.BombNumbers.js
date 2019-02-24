function explodeBomb(arr, bomb) {
    let bombNumber = bomb[0];
    let bombRadius = bomb[1];
    let indexOfBomb = arr.indexOf(bombNumber);

    while (indexOfBomb !== -1) {
        let startExplosionIndex = Math.max(0, indexOfBomb - bombRadius);
        let explosionLength = bombRadius * 2 + 1;
        arr.splice(startExplosionIndex, explosionLength);
        indexOfBomb = arr.indexOf(bombNumber);
    }
    
    let sum = arr.reduce((a, b) => a + b, 0);
    console.log(sum);
}
explodeBomb([1, 2, 2, 4, 2, 2, 2, 9],
    [4, 2]
);