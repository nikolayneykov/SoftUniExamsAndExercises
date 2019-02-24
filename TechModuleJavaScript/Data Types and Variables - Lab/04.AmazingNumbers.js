function isAmazing(num) {
    let sum = 0;
    num = num.toString();
    for (let i = 0; i < num.length; i++) {
        let currentDigit = Number(num[i]);
        sum+=currentDigit;
    }
    sum = sum.toString();
    if (sum.includes('9')) {
        console.log(`${num} Amazing? True`);
    }else{
        console.log(`${num} Amazing? False`);
    }
}

isAmazing(1233)