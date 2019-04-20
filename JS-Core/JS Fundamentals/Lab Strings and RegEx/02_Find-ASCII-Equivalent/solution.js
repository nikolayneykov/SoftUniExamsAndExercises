function solve () {
  let str = document.querySelector('#str').value
  let result = document.querySelector('#result')
  let digits = str.split(' ').filter(x => !isNaN(x))
  let words = str.split(' ').filter(x => isNaN(x))

  words.forEach(word => {
    let p = document.createElement('p')
    p.textContent = word
      .split('')
      .map(x => x.charCodeAt(0))
      .join(' ')

    result.appendChild(p)
  })

  let p = document.createElement('p')
  p.textContent = String.fromCodePoint(...digits)
  result.appendChild(p)
}
