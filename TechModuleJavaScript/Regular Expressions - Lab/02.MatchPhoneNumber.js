function matchPhoneNumber(phoneNumbers) {
    let regex = /\+359(\s|\-)2\1\d{3}\1\d{4}\b/g;
    let validNumbers = [];
    let currentValidNumber = '';
    while ((currentValidNumber = regex.exec(phoneNumbers)) !== null) {
        validNumbers.push(currentValidNumber[0]);
    }
    console.log(validNumbers.join(', '));
}
matchPhoneNumber("+359 2 222 2222,359-2-222-2222, +359/2/222/2222, +359-2 222 2222 +359 2-222-2222, +359-2-222-222, +359-2-222-22222 +359-2-222-2222");