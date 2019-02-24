function cutInHalf(num) {
    let cuts = 0;
    if (num < 1) {
        cuts = 1;
    }
    while (num >= 1) {
        num /= 2;
        cuts++;
    }
    console.log(`Length is ${num.toFixed(2)} cm. after ${cuts} cuts.`);
}
cutInHalf(1);