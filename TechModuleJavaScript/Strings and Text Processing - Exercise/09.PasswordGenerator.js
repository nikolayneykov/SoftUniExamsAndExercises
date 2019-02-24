function generatePassword(params) {
    let password = (params[0].toLowerCase() + params[1].toLowerCase()).split('');
    let word = params[2].toUpperCase();
    let index = 0;
    for (let i in password) {
        index = index === word.length ? 0 : index;
        let char = password[i];
        if (char === 'a' || char === 'e' || char === 'o' || char === 'u' || char === 'i') {
            password[i] = word[index];
            index++;
        }
    }
    password = password.reverse().join('');
    console.log(`Your generated password is ${password}`);
}
generatePassword(['ilovepizza', 'ihatevegetables', 'orange']);