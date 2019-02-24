function isLeap(year) {
    let result = '';
    if (year % 4 === 0 && (year % 100 !== 0 || year % 400 === 0)) {
        result = 'yes';
    } else {
        result = 'no';
    }
    console.log(result);
}
isLeap(2003)