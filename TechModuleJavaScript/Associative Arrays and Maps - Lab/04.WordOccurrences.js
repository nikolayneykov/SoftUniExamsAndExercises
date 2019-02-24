function printWordOccurences(words) {
    let occurences = {};

    for (let word of words) {
        if (!occurences.hasOwnProperty(word)) {
            occurences[word] = 0;
        }
        occurences[word]++;
    }

    let sortedOccurences = Object.entries(occurences)
        .sort((a, b) => b[1] - a[1]);

    for(let occurence of sortedOccurences){
        console.log(`${occurence[0]} -> ${occurence[1]} times`)
    }
}
printWordOccurences(
    ["Here", "is", "the", "first",
        "sentence", "Here", "is", "another",
        "sentence", "And", "finally", "the",
        "third", "sentence"]);