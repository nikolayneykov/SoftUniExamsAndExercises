function printHashtagWords(words) {
    let validWords = words.match(/#[A-Za-z]+/g);
    for(let word of validWords){
        console.log(word.slice(1));
    }
}

printHashtagWords('Nowadays everyone uses # to tag a #special word in #socialMedia');