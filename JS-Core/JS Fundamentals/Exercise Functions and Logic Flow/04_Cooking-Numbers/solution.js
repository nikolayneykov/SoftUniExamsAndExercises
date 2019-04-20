function solve() {
    let input = document.querySelector('input');
    let number = 0;
    let output = document.querySelector('#output');
    Array.from(document.querySelectorAll('button')).forEach(b => b.addEventListener('click', calculate));

    function calculate() {
        if (input.value !== '') {
            number = +input.value;
        }

        switch (this.textContent) {
            case 'Chop': number /= 2; break;
            case 'Dice': number = Math.sqrt(number); break;
            case 'Spice': number++; break;
            case 'Bake': number *= 3; break;
            case 'Fillet': number *= 0.8; break;
        }

        output.textContent = number;
        input.value = '';
    }
}


