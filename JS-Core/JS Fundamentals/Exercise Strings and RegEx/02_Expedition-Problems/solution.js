function solve () {
  let keyword = document.querySelector('#str').value
  let text = document.querySelector('#text').value
  let result = document.querySelector('#result')

  let regex = /(north|east).*?(\d{2})[^,]*?,[^,]*?(\d{6})/gim
  let north = ''
  let east = ''
  let match = regex.exec(text)

  while (match !== null) {
    if (match[1].toLowerCase() === 'north') {
      north = `${match[2]}.${match[3]} N`
    } else if (match[1].toLowerCase() === 'east') {
      east = `${match[2]}.${match[3]} E`
    }

    match = regex.exec(text)
  }

  let message =
    'Message: ' + text.match(new RegExp(`${keyword}(.*)${keyword}`))[1]

  let pNorth = document.createElement('p')
  pNorth.textContent = north
  let pEast = document.createElement('p')
  pEast.textContent = east
  let pMessage = document.createElement('p')
  pMessage.textContent = message

  result.appendChild(pNorth)
  result.appendChild(pEast)
  result.appendChild(pMessage)
}
