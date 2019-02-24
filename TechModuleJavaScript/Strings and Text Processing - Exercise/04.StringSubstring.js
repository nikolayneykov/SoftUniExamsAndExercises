function hasSubstring(str, text) {
    let regex = new RegExp(`\\b${str}\\b`, 'i');
    let result = '';
    if (regex.test(text)) {
        result = str;
    } else {
        result = `${str} not found!`;
    }
    console.log(result);
}
hasSubstring('javascript',
    'JavaScript is the best programming language'
);