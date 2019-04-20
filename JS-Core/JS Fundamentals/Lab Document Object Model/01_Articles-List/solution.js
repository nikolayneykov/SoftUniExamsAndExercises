function solve() {
	let title = document.getElementById('createTitle');
	let content = document.getElementById('createContent');
	let articles = document.getElementById('articles');

	if (title.value !== '' && content.value !== '') {
		let article = document.createElement('article');
		let h3 = document.createElement('h3');
		h3.textContent = title.value;
		let p = document.createElement('p');
		p.textContent = content.value;

		article.appendChild(h3);
		article.appendChild(p);
		articles.appendChild(article);

		title.value = '';
		content.value = '';
	}
}