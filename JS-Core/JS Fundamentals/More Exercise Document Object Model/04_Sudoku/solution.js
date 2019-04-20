function solve() {
  let table = document.querySelector('table');
  let message = document.querySelector('#check p');

  let [firstRow, secondRow, thirdRow] = document.querySelectorAll('tbody tr');
  let [quickCheck, clear] = document.querySelectorAll('button');

  quickCheck.addEventListener('click', validateSudoku);
  clear.addEventListener('click', clearData);


  function validateSudoku() {
    let allValues = document.querySelectorAll('input').values;

    let firstRowInputs = Array.from(new Set(Array.from(firstRow.children).map(x => +x.children[0].value)));
    let secondRowInputs = Array.from(new Set(Array.from(secondRow.children).map(x => +x.children[0].value)));
    let thirdRowInputs = Array.from(new Set(Array.from(thirdRow.children).map(x => +x.children[0].value)));

    let firstColum = new Set([firstRowInputs[0], secondRowInputs[0], thirdRowInputs[0]]);
    let secondColum = new Set([firstRowInputs[1], secondRowInputs[1], thirdRowInputs[1]]);
    let thirdColum = new Set([firstRowInputs[2], secondRowInputs[2], thirdRowInputs[2]]);

    if (firstRowInputs.length === 3 && secondRowInputs.length === 3 && thirdRowInputs.length === 3 &&
        firstColum.size === 3 && secondColum.size === 3 && thirdColum.size === 3) {

      table.style.border = '2px solid green';
      message.textContent = 'You solve it! Congratulations!';
      message.style.color = 'green';

    } else {
      table.style.border = '2px solid darkred';
      message.textContent = 'NOP! You are not done yet...';
      message.style.color = 'darkred';
    }
  }

  function clearData() {
    Array.from(document.querySelectorAll('tbody tr td input')).forEach(d => d.value = '');
    table.style.border = 'none';
    message.textContent = '';
  }
}

