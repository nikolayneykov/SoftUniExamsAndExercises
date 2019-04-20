function solve() {
  let arr = JSON.parse(document.querySelector('#arr').value).filter((x, i) => i % 2 === 0).join(' x ');
  document.querySelector('#result').textContent = arr;
}