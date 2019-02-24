function censoreWords(text, word) {
    let regex = new RegExp(word, 'g');
    console.log(text.replace(regex, '*'.repeat(word.length)));
}
censoreWords("A small sentence with some words", "small");