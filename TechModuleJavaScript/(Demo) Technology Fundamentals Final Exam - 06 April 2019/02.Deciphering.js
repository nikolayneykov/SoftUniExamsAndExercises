function solve ([encryptedSting, substrings]) {
  if (!encryptedSting.match(/^[d-z{}|#\s]+$/)) {
    console.log('This is not the book you are looking for.')
  } else {
    let [firstSubstring, secondSubstring] = substrings.split(' ')
    let decryptedString = encryptedSting
      .split('')
      .map(x => String.fromCharCode(x.charCodeAt(0) - 3))
      .join('')
      .replace(new RegExp(firstSubstring, 'g'), secondSubstring)

    console.log(decryptedString)
  }
}

solve([
  'wkhfn#|rx#jhqfkr#phf#exw#|rxu#uholf#lv#khfgohg#lq#hfrwkhu#sohfhw',
  'ec an'
])
