function solve () {
  let num = Number(document.getElementById('num').value)
  let resultElement = document.getElementById('result')

  let sequence = ['A', 'T', 'C', 'G', 'T', 'T', 'A', 'G', 'G', 'G']
  for (let i = 0; i < num; i++) {
    let symbol1 = sequence.shift()
    let symbol2 = sequence.shift()

    sequence.push(symbol1)
    sequence.push(symbol2)

    let pElement = document.createElement('p')

    if (i % 5 === 0 || i % 5 === 4) {
      pElement.textContent = `**${symbol1}${symbol2}**`
      if (i % 5 === 4) {
        i++
        num++
      }
    } else if (i % 5 === 1 || i % 5 === 3) {
      pElement.textContent = `*${symbol1}--${symbol2}*`
    } else if (i % 5 === 2) {
      pElement.textContent = `${symbol1}----${symbol2}`
    }

    resultElement.appendChild(pElement)
  }
}
