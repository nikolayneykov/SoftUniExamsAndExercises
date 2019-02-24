function extractSubstring(word, text) {
    let arr = text.split(' ');
    for (let i = 0; i < arr.length; i++) {
        let currentWord = arr[i];
        if (currentWord.toLowerCase().includes(word.toLowerCase())) {
            arr.splice(i, 1);
            i--;
        }
    }
    arr.forEach((x, index) => console.log(`idx[${index}] -> ${x}`));
}
extractSubstring('wel', 'Welcome to the Software University!');