function isMatched(firstStr, char, lastStr) {
    firstStr = firstStr.replace('_', char);
    if (firstStr === lastStr) {
        console.log('Matched');
    } else {
        console.log('Not Matched');
    }
}

isMatched('Str_ng', 'I', 'Strong');