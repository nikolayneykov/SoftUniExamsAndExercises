function revealWords(words, text) {
    words = words.split(', ');

    for (let word of words) {
        let hiddenWord = '*'.repeat(word.length);
        text = text.replace(hiddenWord, word);
    }

    console.log(text);
}
revealWords('great, learning',
    'softuni is ***** place for ******** new programming languages'
);