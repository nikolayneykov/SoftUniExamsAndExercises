function printMatch(word, text) {
    word = word.toLowerCase();
    text = text.toLowerCase().split(' ');
    let foundMatch = false;

    for (let w of text) {
        if (w === word) {
            foundMatch = true;
            break;
        }
    }

    console.log(foundMatch ? word : `${word} not found!`);
}
printMatch(
    'javascript',
    'JavaScript is the best programming language'
);