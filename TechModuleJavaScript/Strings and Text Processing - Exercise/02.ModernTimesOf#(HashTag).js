function findHashtagWords(text) {
    let regex = new RegExp(/#[A-Za-z]+/, 'g');
    let word = '';
    while (word = regex.exec(text)) {
        console.log(word.toString().slice(1));
    }
}
findHashtagWords('Nowadays everyone uses # to tag a #special word in #socialMedia');