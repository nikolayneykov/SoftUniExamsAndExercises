function solve () {
  document.querySelector('button').addEventListener('click', function () {
    let input = document.querySelector('#input').value
    let count = input.match(/^\d+/)[0]
    let takenChars = input.slice(count.length, +count + count.length)
    let lastChar = takenChars[takenChars.length - 1]
    let [firstPart, secondPart] = takenChars.split(lastChar)
    let regex = new RegExp(`[${firstPart}]`)

    let result = secondPart
      .split('')
      .filter(x => !regex.test(x))
      .map(x => x.replace('#', ' '))
      .join('')

    document.querySelector('#output').value = result
  })
}
