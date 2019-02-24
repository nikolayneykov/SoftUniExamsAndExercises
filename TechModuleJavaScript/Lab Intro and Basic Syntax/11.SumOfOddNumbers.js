function printOddNumbers(num) {
    let sum = 0;
    for(let i = 1;num>0;num--,i+=2){
        console.log(i);
        sum+=i;
    }
    console.log('Sum: '+sum);
}
printOddNumbers(5);