function solve (params) {
  class Rectangle {
    constructor (width, height) {
      this.width = width
      this.height = height
    }

    area () {
      return this.width * this.height
    }

    compareTo (other) {
      return this.area() !== other.area()
        ? other.area() - this.area()
        : other.width - this.width
    }
  }

  let rectangles = params.map(([width, height]) => new Rectangle(width, height))

  return rectangles.sort((a, b) => a.compareTo(b))
}

console.log(solve([[1, 20], [20, 1], [5, 3], [5, 3]]))
