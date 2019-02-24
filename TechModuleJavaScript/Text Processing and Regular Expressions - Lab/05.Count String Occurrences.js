function printOccurencesCount(text, word) {
    let regex = new RegExp(`\\b${word}\\b`, 'g');
    let a = regex.exec(text);
    a = regex.exec(text);
    console.log(a);
    let str = 'abc';
    str.se
    
}
printOccurencesCount("This is a word and it also is a sentence",
    "is"
);