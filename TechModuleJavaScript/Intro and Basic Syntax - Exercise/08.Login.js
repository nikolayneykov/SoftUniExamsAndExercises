function login(arr) {
    let username = arr[0];
    let password = '';
    for (let i = username.length - 1; i >= 0; i--) {
        password += username[i];
    }

    for (let i = 1; i <= arr.length - 1; i++) {
        if (password === arr[i]) {
            console.log(`User ${username} logged in.`);
            break;
        } else if (i !== arr.length - 1) {
            console.log('Incorrect password. Try again.');
        } else {
            console.log(`User ${username} blocked!`);
        }
    }
}
login(['sunny','rainy','cloudy','sunny','not sunny']);