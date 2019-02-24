function printEmoticons(text) {
    text = text.split(' ');

    for (let word of text) {
        if (word.length === 2 && word[0] === ':') {
            console.log(word);
        }
    }
}
printEmoticons('There are so many emoticons nowadays :P I have many ideas :O what input to place here :)');