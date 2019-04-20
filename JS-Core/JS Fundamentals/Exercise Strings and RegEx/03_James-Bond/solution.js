function solve () {
  let [specialKey, ...messages] = JSON.parse(document.querySelector('#arr').value)
  let result = document.querySelector('#result')
  let regex = new RegExp(
    `(?<=\\s|^)${specialKey}\\s+([A-Z!%$#]{8,})(?=\\s|\\.|,|$)`,
    'gi'
  )
  messages.forEach(line => {
    let match = regex.exec(line)

    while (match) {
      let message = match[1]

      if (message === message.toUpperCase()) {
        let newMessage = message
          .toLowerCase()
          .split('')
          .map(c =>
            c === '!' ? 1 : c === '%' ? 2 : c === '#' ? 3 : c === '$' ? 4 : c
          )
          .join('')

        line = line.replace(message, newMessage)
      }
      match = regex.exec(line)
    }
    let p = document.createElement('p')
    p.textContent = line
    result.appendChild(p)
  })
}

// solve([
//   'specialKey',
//   'In this text the specialKey HELLOWORLD! is correct, but',
//   'the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while',
//   'SpeCIaLkeY SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!'
// ])

// [
//   "specialKey",
//   "In this text the specialKey HELLOWORLD! is correct, but",
//   "the following specialKey $HelloWorl#d and spEcIaLKEy HOLLOWORLD1 are not, while",
//   "SpeCIaLkeY SOM%%ETH$IN and SPECIALKEY ##$$##$$ are!"
// ]
