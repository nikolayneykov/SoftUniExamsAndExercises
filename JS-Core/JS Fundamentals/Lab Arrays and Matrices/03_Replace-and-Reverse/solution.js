function solve() {
  let arr = JSON.parse(document.querySelector('#arr').value)
    .map(x => x.split('').reverse().join(''))
    .map(x => x = x[0].toUpperCase() + x.slice(1));

  document.querySelector('#result').textContent = arr.join(' ');
}