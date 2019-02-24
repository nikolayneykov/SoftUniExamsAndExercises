function printCharsAtRange(char1, char2) {
    let start = Math.min(char1.charCodeAt(0),char2.charCodeAt(0));
    let end = Math.max(char1.charCodeAt(0),char2.charCodeAt(0));
    let result = [];
    for(let i = start+1;i<end;i++){
        result.push(String.fromCharCode(i));
    }
    console.log(result.join(' '));
}
printCharsAtRange('a', 'z');
