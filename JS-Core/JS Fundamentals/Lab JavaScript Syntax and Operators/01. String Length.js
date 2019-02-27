function printStringsLength(str1, str2, str3) {
    let sumLength = str1.length + str2.length + str3.length;
    let averageSumLength = Math.floor(sumLength / 3);

    console.log(`${sumLength}\n${averageSumLength}`);
}

printStringsLength('chocolate', 'ice cream', 'cake');