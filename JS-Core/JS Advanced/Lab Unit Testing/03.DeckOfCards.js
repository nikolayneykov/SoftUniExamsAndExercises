function printDeckOfCards (cards) {
  function makeCard (face, suit) {
    const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
    const suits = { S: '\u2660', H: '\u2665', D: '\u2666', C: '\u2663' }

    if (!faces.includes(face) || !suits.hasOwnProperty(suit)) {
      return `Invalid card: ${face}${suit}`
    }

    return `${face}${suits[suit]}`
  }

  cards = cards.map(c => makeCard(c.slice(0, c.length - 1), c[c.length - 1]))
  console.log(cards.join(' '))
}

printDeckOfCards(['AS', '10D', 'KH', '2C'])
printDeckOfCards(['5S', '3D', 'QD', '1C'])
