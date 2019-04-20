function solve() {
  let arr = JSON.parse(document.querySelector('#arr').value);
  let result = document.querySelector('#result');

  let ascendingOrderDiv = document.createElement('div');
  ascendingOrderDiv.textContent = arr.map(Number).sort((a, b) => a - b).join(', ');

  let alphabeticalOrderDiv = document.createElement('div');
  alphabeticalOrderDiv.textContent = arr.sort((a, b) => a.localeCompare(b)).join(', ');

  result.appendChild(ascendingOrderDiv);
  result.appendChild(alphabeticalOrderDiv);
}