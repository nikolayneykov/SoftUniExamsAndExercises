function leapYear() {
    let input = document.querySelector('input');
    let h2 = document.querySelector('#year h2');
    let div = document.querySelector('#year div');
    document.querySelector('button').addEventListener('click', checkLeapYear);

    function checkLeapYear() {
        let year = +input.value;
        div.textContent = year;

        if (year % 400 === 0 || (year % 4 === 0 && year % 100 !== 0)) {
            h2.textContent = 'Leap Year';
        }else{
            h2.textContent = 'Not Leap Year';
        }

        input.value = '';
    }
}