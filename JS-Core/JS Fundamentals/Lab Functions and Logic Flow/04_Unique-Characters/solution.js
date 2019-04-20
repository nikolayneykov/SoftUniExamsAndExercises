function solve() {
  let uniqueChars = document.querySelector('#string').value
    .split('')
    .filter((e, i, arr) => e === ' ' || i === arr.indexOf(e))
  document.querySelector('#result').textContent = uniqueChars.join('');
}