const result = (function cards () {
  let suits = {
    CLUBS: '\u2663',
    DIAMONDS: '\u2666',
    HEARTS: '\u2665',
    SPADES: '\u2660'
  }

  const faces = [
    '2',
    '3',
    '4',
    '5',
    '6',
    '7',
    '8',
    '9',
    '10',
    'J',
    'Q',
    'K',
    'A'
  ]

  class Card {
    constructor (face, suit) {
      this._face = null
      this._suit = null
      this.face = face
      this.suit = suit
    }

    get face () {
      return this._face
    }

    set face (value) {
      if (!faces.includes(value)) {
        throw Error('Invalid face!')
      }

      this._face = value
    }

    get suit () {
      return this._suit
    }

    set suit (suit) {
      if (!Object.values(suits).includes(suit)) {
        throw Error('Invalid suit!')
      }

      this._suit = suit
    }

    toString () {
      return `${this._face}${this._suit}`
    }
  }

  return {
    Suits: suits,
    Faces: faces,
    Card: Card
  }
})()

const Card = result.Card
const Suits = result.Suits

let card = new Card('Q', Suits.CLUBS)
card.face = 'A'
card.suit = Suits.DIAMONDS
