function printOddOccurences(params) {
    let occurences = {};
    let words = params.split(' ').filter(x => x !== '').map(word => word.toLowerCase());

    for (let word of words) {
        word = ' ' + word;
        if (!occurences.hasOwnProperty(word)) {
            occurences[word] = 0;
        }
        occurences[word]++;
    }

    let oddOccurences = [];
    for (let word in occurences) {
        let count = occurences[word];
        if (count % 2 === 1) {
            oddOccurences.push(word);
        }
    }

    console.log(oddOccurences.join(''));
}
printOddOccurences('Java C# Php PHP Java PhP 3 C# 3 1 5 C#');