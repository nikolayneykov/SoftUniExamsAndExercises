function solve() {
	let input = document.querySelector('input');
	let allNumbers = document.querySelector('#allNumbers');
	let button = document.querySelector('button');
	button.addEventListener('click', showNumbers);

	function showNumbers() {
		let numbers = input.value.split(' ').map(Number);

		if (numbers.length === 6 && numbers.every(n => n >= 1 && n <= 49)) {

			for (let i = 1; i <= 49; i++) {
				let div = document.createElement('div');
				div.setAttribute('class', 'numbers');
				div.textContent = i;

				if (numbers.includes(i)) {
					div.style.background = 'orange';
				}

				allNumbers.appendChild(div);
			}

			input.disabled = true;
			button.disabled = true;
		}
	}
}