function solve() {
  let number = +document.querySelector('#num1').value;
  let type = document.querySelector('#type').value.toLowerCase();
  let result = document.querySelector('#result');

  if (type === 'celsius') {
    result.textContent = Math.round(number * 1.8 + 32);
  } else if (type === 'fahrenheit') {
    result.textContent = Math.round((number - 32) / 1.8);
  } else {
    result.textContent = 'Error!';
  }
}