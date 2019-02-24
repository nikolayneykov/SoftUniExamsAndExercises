function printSplitedWords(str) {
   let splitedWords = str.match(/[A-Z][a-z]*/g);
   console.log(splitedWords.join(', '));
}
printSplitedWords('SplitMeIfYouCanHaHaYouCantOrYouCan');