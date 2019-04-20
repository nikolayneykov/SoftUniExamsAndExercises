function solve() {
  let num1 = +document.querySelector('#num1').value;
  let num2 = +document.querySelector('#num2').value;
  let result = document.querySelector('#result');

  if (num1 > num2) {
    result.textContent = 'Try with other numbers.';
  } else {
    for (let i = num1; i <= num2; i++) {
      let p = document.createElement('p');
      p.textContent = `${i} * ${num2} = ${i*num2}`;
      result.appendChild(p);
    }
  }
}