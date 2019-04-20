function validate() {
    const months = {
        'January': '01', 'February': '02', 'March': '03', 'April': '04',
        'May': '05', 'June': '06', 'July': '07', 'August': '08',
        'September': '09', 'October': '10', 'November': '11', 'December': '12'
    };
    const weights = [2, 4, 8, 5, 10, 9, 7, 3, 6];

    let year = document.querySelector('#year');
    let month = document.querySelector('#month');
    let date = document.querySelector('#date');
    let male = document.querySelector('#male');
    let female = document.querySelector('#female');
    let region = document.querySelector('#region');
    let result = document.querySelector('#egn');
    document.querySelector('button').addEventListener('click', generateEgn);

    function generateEgn() {
        let egn = '';
        egn += year.value.slice(2);
        egn += months[month.value];
        egn += date.value.padStart(2, '0');
        egn += region.value.slice(0, 2);
        egn += male.checked ? '2' : '1';

        let sum = egn.split('')
            .map(Number)
            .map((n, i) => n * weights[i])
            .reduce((a, b) => a + b, 0);

        let lastDigit = sum % 11 === 10 ? 0 : sum % 11;
        egn += lastDigit;
        result.textContent = `Your EGN is: ${egn}`;

        year.value = '';
        month.value = '';
        date.value = '';
        male.checked = false;
        female.checked = false;
        region.value = '';
    }
}