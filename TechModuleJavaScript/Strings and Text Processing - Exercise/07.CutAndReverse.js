function cutAndReverse(str) {
    let count = str.length / 2;
    let firstPart = str.slice(0, count).split('').reverse().join('');
    let secondPart = str.slice(count).split('').reverse().join('');
    console.log(firstPart + '\n' + secondPart);
}
cutAndReverse('tluciffiDsIsihTgnizamAoSsIsihT');