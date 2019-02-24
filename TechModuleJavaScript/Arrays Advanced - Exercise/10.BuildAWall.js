function buildWall(wall) {
    let totalUsedConcrete = [];
    let totalPrice = 0;
    let isComplete = false;

    while (!isComplete) {
        isComplete = true;
        let currenttUsedConcrete = 0;
        
        for (let i = 0; i < wall.length; i++) {
            if (wall[i] < 30) {
                wall[i]++;
                currenttUsedConcrete += 195;
                isComplete = false;
            }
        }

        if (!isComplete) {
            totalUsedConcrete.push(currenttUsedConcrete);
            totalPrice += currenttUsedConcrete * 1900;
        }
    }

    console.log(`${totalUsedConcrete.join(', ')}\n${totalPrice} pesos`);
}
buildWall([21, 25, 28])