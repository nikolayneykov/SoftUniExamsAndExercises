function solve () {
  class Figure {
    constructor () {
      if (new.target === Figure) {
        throw new Error('Cannot instantiate abstract class!')
      }
    }

    get area () {
      return this._area
    }

    toString () {
      return this.constructor.name
    }
  }

  class Circle extends Figure {
    constructor (radius) {
      super()
      this.radius = radius
    }

    get area () {
      return Math.PI * this.radius ** 2
    }

    toString () {
      return super.toString() + ` - radius: ${this.radius}`
    }
  }

  class Rectangle extends Figure {
    constructor (width, height) {
      super()
      this.width = width
      this.height = height
    }

    get area () {
      return this.width * this.height
    }

    toString () {
      return (
        super.toString() + ` - width: ${this.width}, height: ${this.height}`
      )
    }
  }

  return { Figure, Circle, Rectangle }
}
