function solve () {
  class Melon {
    constructor (weight, melonSort) {
      if (new.target === Melon) {
        throw new TypeError('Abstract class cannot be instantiated directly')
      }

      this.weight = +weight
      this.melonSort = melonSort
      this.element = null
    }

    get elementIndex () {
      return this.weight * this.melonSort.length
    }

    toString () {
      return (
        `Element: ${this.element}` +
        `\nSort: ${this.melonSort}` +
        `\nElement Index: ${this.elementIndex}`
      )
    }
  }

  class Watermelon extends Melon {
    constructor (weight, melonSort) {
      super(weight, melonSort)
      this.element = 'Water'
    }
  }

  class Firemelon extends Melon {
    constructor (weight, melonSort) {
      super(weight, melonSort)
      this.element = 'Fire'
    }
  }

  class Earthmelon extends Melon {
    constructor (weight, melonSort) {
      super(weight, melonSort)
      this.element = 'Earth'
    }
  }

  class Airmelon extends Melon {
    constructor (weight, melonSort) {
      super(weight, melonSort)
      this.element = 'Air'
    }
  }

  class Melolemonmelon extends Watermelon {
    constructor (weight, melonSort) {
      super(weight, melonSort)
      this.elements = ['Water', 'Fire', 'Earth', 'Air']
    }
    morph () {
      this.elements.push(this.elements.shift())
      this.element = this.elements[0]
    }
  }

  return { Melon, Watermelon, Firemelon, Earthmelon, Airmelon, Melolemonmelon }
}
