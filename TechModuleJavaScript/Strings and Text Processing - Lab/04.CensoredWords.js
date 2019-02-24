function censoreWord(text, word) {
    let replacement = '*'.repeat(word.length);
    let regex = new RegExp(word, 'g')
    text = text.replace(regex, replacement);
    console.log(text);
}
censoreWord("A small sentence with some words", "small");