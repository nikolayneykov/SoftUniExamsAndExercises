function validatePassword(password) {
    let result = [];
    if (!/.{6,10}/.test(password)) {
        result.push('Password must be between 6 and 10 characters');
    }
    if (!/^[a-zA-Z0-9]+$/.test(password)) {
        result.push('Password must consist only of letters and digits');
    }
    if (!/\d{2,}/.test(password)) {
        result.push('Password must have at least 2 digits');
    }
    if (result.length === 0) {
        result.push('Password is valid');
    }

    console.log(result.join('\n'));
}
validatePassword('MyPass123');
validatePassword('++');