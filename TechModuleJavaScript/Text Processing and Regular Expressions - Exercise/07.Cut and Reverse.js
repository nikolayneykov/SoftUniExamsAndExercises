function cutAndReverse(str) {
    let midIndex = str.length / 2;
    let firstHalf = str.slice(0,midIndex).split('').reverse().join('');
    let secondHalf = str.slice(midIndex).split('').reverse().join('');
    console.log(`${firstHalf}\n${secondHalf}`);
}

cutAndReverse('tluciffiDsIsihTgnizamAoSsIsihT');