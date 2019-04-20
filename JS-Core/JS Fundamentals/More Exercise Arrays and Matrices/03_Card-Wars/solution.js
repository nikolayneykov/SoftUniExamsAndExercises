function solve () {
  let [player1Deck, player2Deck] = JSON.parse(
    document.querySelector('#arr').value
  )
  let result = document.querySelector('#result')

  let getCardValue = card => {
    let cardValue = 0
    if (card >= 2 && card <= 10) {
      cardValue = +card
    } else if (card === 'J') {
      cardValue = 11
    } else if (card === 'Q') {
      cardValue = 12
    } else if (card === 'K') {
      cardValue = 13
    } else if (card === 'A') {
      cardValue = 14
    }

    return cardValue
  }

  let round = 1
  while (round <= 20 && player1Deck.length > 0 && player2Deck.length > 0) {
    let player1Card = player1Deck.shift()
    let player2Card = player2Deck.shift()

    if (getCardValue(player1Card) > getCardValue(player2Card)) {
      player1Deck.push(...[player1Card, player2Card])
    } else {
      player2Deck.push(...[player1Card, player2Card])
    }
    round++
  }

  let first = document.createElement('p')
  first.textContent = `First -> ${player1Deck.join(', ')}`

  let second = document.createElement('p')
  second.textContent = `Second -> ${player2Deck.join(', ')}`

  result.appendChild(first)
  result.appendChild(second)
}
