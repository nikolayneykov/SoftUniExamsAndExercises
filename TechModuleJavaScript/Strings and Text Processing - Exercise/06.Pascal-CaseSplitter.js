function splitWords(str) {
    let regex = new RegExp('[A-Z][a-z]*', 'g');
    let result = [];
    let word = '';
    while (word = regex.exec(str)) {
        result.push(word);
    }
    console.log(result.join(', '));
}
splitWords('SplitMeIfYouCanHaHaYouCantOrYouCan');