function solve() {
  let num = +document.querySelector('#num').value;
  let result = document.querySelector('#result');
  let arr = [];
  
  JSON.parse(document.querySelector('#arr').value)
    .forEach(x => {
      arr.push(`${x.indexOf(num) !== -1} -> ${x.indexOf(num)}`);
    });

  result.textContent = arr.join(',');
}
