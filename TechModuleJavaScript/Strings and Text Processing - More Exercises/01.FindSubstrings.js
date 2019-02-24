function findSubstrings(text, word) {
    let regex = new RegExp(word, 'gi');
    let count = 0;
    let r = '';
    while (r = regex.exec(text)) {
        count++;
    }
    console.log(count);
}
findSubstrings("Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.", "wel");