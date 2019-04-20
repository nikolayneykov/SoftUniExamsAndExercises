function solve() {
  let input = document.getElementById('input');
  let sentences = input.textContent.toString()
    .split('.')
    .filter(x => x !== '')
    .map(x => x += '.');
    
  let output = document.getElementById('output');

  for (let i = 0; i < sentences.length; i++) {

    let p = document.createElement('p');
    for (let j = 1; j <= 3 && i < sentences.length; j++ , i++) {
      p.textContent += sentences[i];
    }

    output.appendChild(p);
    i--;
  }

  input.remove();
}