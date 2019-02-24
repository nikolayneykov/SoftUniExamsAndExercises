function printShortestAndLongestWord(sentence) {
    sentence = sentence.split(/[\.\,\!\?\#\s]/).filter(x => x !== '');
    let shortestWord = sentence[0];
    let longestWord = sentence[0];

    for (let i = 1; i < sentence.length; i++) {
        let currentWord = sentence[i];
        if (shortestWord.length > currentWord.length) {
            shortestWord = currentWord;
        }
        if (longestWord.length < currentWord.length) {
            longestWord = currentWord;
        }
    }
    console.log(`Longest -> ${longestWord}\nShortest -> ${shortestWord}`);
}
printShortestAndLongestWord('! ??  #####################  Hello people, are you familiar with the terms of application, at the software university?');