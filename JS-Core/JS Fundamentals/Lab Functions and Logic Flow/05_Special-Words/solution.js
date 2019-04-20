function solve() {
  let firstNumber = +document.querySelector('#firstNumber').value;
  let secondNumber = +document.querySelector('#secondNumber').value;
  let firstString = document.querySelector('#firstString').value;
  let secondString = document.querySelector('#secondString').value;
  let thirdString = document.querySelector('#thirdString').value;
  let result = document.querySelector('#result');

  for (let i = firstNumber; i <= secondNumber; i++) {
    let p = document.createElement('p');
    p.textContent = i;

    if (i % 3 === 0 && i % 5 === 0) {
      p.textContent += ` ${firstString}-${secondString}-${thirdString}`;
    } else if (i % 3 === 0) {
      p.textContent += ` ${secondString}`;
    } else if (i % 5 === 0) {
      p.textContent += ` ${thirdString}`;
    }

    result.appendChild(p);
  }
}