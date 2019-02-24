function countStringOcurences(text, word) {
    let regex = new RegExp(`\\b${word}\\b`, 'g');
    let count = 0;
    while (regex.exec(text)) {
        count++;
    }
    console.log(count);
}
countStringOcurences("This is a word and it also is a sentence",
    "is"
);