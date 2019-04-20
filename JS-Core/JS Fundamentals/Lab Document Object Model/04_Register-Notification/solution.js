function register() {
  let username = document.getElementById('username');
  let email = document.getElementById('email');
  let password = document.getElementById('password');

  if (username.value !== '' && email.value.match(/(.+)@(.+).(com|bg)/gm) && password.value !== '') {
    let section = document.getElementById('result');

    section.innerHTML = "<h1>Successful Registration!</h1>" +
      `Username: ${username.value}` +
      "<br>" +
      `Email: ${email.value}` +
      "<br>" +
      `Password: ${"*".repeat(password.value.length)}`;

    username.value = '';
    email.value = '';
    password.value = '';
    setTimeout(() => {
      section.innerHTML = '';
    }, 5000);
  }
}
