function generatePassword(params) {
    let password = (params[0] + params[1]).toLowerCase().split('');
    let replacementChars = params[2].toUpperCase().split('');

    for (let i in password) {
        let char = password[i];

        if (char === 'a' || char === 'e' || char === 'i' || char === 'o' || char === 'u') {
            let replacement = replacementChars.shift();
            replacementChars.push(replacement);
            password[i] = replacement;
        }
    }

    console.log(`Your generated password is ${password.reverse().join('')}`);
}
generatePassword(['ilovepizza', 'ihatevegetables', 'orange']);