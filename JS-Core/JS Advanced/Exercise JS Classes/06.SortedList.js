class SortedList {
  constructor () {
    this.list = []
    this.size = 0
  }

  add (elemenent) {
    this.list.push(elemenent)
    this.size++
    this.sort()
  }

  remove (index) {
    if (index < 0 || index >= this.list.length) {
      throw new Error('Invalid is out of range!')
    }

    this.list.splice(index, 1)
    this.size--
  }

  get (index) {
    if (index < 0 || index >= this.list.length) {
      throw new Error('Invalid is out of range!')
    }

    return this.list[index]
  }

  sort () {
    this.list.sort((a, b) => a - b)
  }
}
