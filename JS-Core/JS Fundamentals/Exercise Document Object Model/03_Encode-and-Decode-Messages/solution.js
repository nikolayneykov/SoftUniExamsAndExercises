function solve() {
	let [originalMessage, encodedMessage] = document.querySelectorAll('textarea');
	let [encodeBtn, decodeBtn] = document.querySelectorAll('button');

	encodeBtn.addEventListener('click', encode);
	decodeBtn.addEventListener('click', decode);

	function encode() {
		let encodedText = originalMessage.value
			.split('')
			.map(c => String.fromCharCode(c.charCodeAt(0) + 1))
			.join('');

		encodedMessage.value = encodedText;
		originalMessage.value = '';
	}

	function decode() {
		encodedMessage.value = encodedMessage.value
			.split('')
			.map(c => String.fromCharCode(c.charCodeAt(0) - 1))
			.join('');
	}
}