function extractSpice(startingYield) {
    let day = 0;
    let extractedSpice = 0;

    while (startingYield >= 100) {
        day++;
        extractedSpice += startingYield - 26;
        startingYield -= 10;
    }
    extractedSpice -= 26;
    extractedSpice = Math.max(extractedSpice, 0);
    console.log(day + '\n' + extractedSpice)
}
extractSpice(111);
