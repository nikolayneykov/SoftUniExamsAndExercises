function solve() {
  let string = document.querySelector('#string').value;
  let char = document.querySelector('#character').value;
  let count = string.split('').filter(x => x === char).length;
  document.querySelector('#result').textContent = `Count of ${char} is ${count % 2 === 0 ? 'even' : 'odd'}.`;
}