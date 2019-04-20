function solve () {
  let input = document.querySelector('input').value
  let weight = input

  while (weight > 9) {
    weight = weight
      .toString()
      .split('')
      .map(Number)
      .reduce((a, b) => a + b, 0)
  }

  let result = input
    .slice(weight, input.length - weight)
    .match(/.{1,8}/g)
    .map(segment => String.fromCharCode(Number.parseInt(segment, 2)))
    .filter(x => /[A-Za-z\s]/.test(x))
    .join('')

  document.querySelector('#result').textContent = result
}
