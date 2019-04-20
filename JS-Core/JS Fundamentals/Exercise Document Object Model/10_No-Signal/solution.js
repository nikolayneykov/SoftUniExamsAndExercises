function solve() {
	let div = document.querySelector('#exercise div');

	setInterval(() => {
		let left = Math.random() * 81;
		let top = Math.random() * 45;

		div.style.marginLeft = `${left}%`;
		div.style.marginTop = `${top}%`;
	}, 1000);
}