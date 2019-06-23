(function cards () {
  let suits = {
    CLUBS: '\u2663',
    DIAMONDS: '\u2666',
    HEARTS: '\u2665',
    SPADES: '\u2660'
  }
 
  const faces = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A']
 
  class Card {
    constructor (face, suit) {
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
 
    set suit (value) {
      if (!Object.values(suits).includes(value)) {
        throw Error('Invalid suit!')
      }
 
      this._suit = value
    }
 
    toString () {
      return `${this.face}${this.suit}`
    }
  }
 
  return {
    Suits: suits,
    Faces: faces,
    Card: Card
  }
})()