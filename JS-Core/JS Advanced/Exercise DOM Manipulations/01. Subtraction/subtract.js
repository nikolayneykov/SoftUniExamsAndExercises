function subtract () {
  let firstNum = +document.querySelector('#firstNumber').value
  let secondNum = +document.querySelector('#secondNumber').value
  document.querySelector('#result').textContent = firstNum - secondNum
}
