function solve() {
  let arr = JSON.parse(document.querySelector('#arr').value).map(Number);
  let result = document.querySelector('#result');

  for (let index in arr) {
    let p = document.createElement('p');
    p.textContent = `${index} -> ${arr[index] * arr.length}`;
    result.appendChild(p);
  }
}