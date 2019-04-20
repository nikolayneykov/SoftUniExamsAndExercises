function solve () {
  let str = document.querySelector('#str').value
  let num = document.querySelector('#num').value
  let result = str.match(new RegExp(`.{1,${num}}`, 'g'))
  let lastElement = result.pop()
  lastElement += str.slice(0, num - lastElement.length)
  result.push(lastElement)
  document.querySelector('#result').textContent = result.join(' ')
}
