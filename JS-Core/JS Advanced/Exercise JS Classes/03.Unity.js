class Rat {
  constructor (name) {
    this.name = name
    this.rats = []
  }

  getRats () {
    return this.rats
  }

  unite (otherRat) {
    if (otherRat instanceof Rat) {
      this.rats.push(otherRat)
    }
  }

  toString () {
    return [this.name, ...this.rats.map(r => `##${r}`)].join('\n')
  }
}

let test = new Rat('Pesho')

console.log(test.toString()) // Pesho

console.log(test.getRats()) // []

test.unite(new Rat('Gosho'))
test.unite(new Rat('Sasho'))
console.log(test.getRats())
// [ Rat { name: 'Gosho', unitedRats: [] },
//  Rat { name: 'Sasho', unitedRats: [] } ]

console.log(test.toString())
// Pesho
// ##Gosho
// ##Sasho
