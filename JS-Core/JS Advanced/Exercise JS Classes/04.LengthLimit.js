class Stringer {
  constructor (innerString, innerLength) {
    this.innerString = innerString
    this.innerLength = innerLength
  }

  increase (length) {
    this.innerLength += length
  }

  decrease (length) {
    this.innerLength = Math.max(0, this.innerLength - length)
  }

  toString () {
    return (
      this.innerString.slice(0, this.innerLength) +
      (this.innerString.length > this.innerLength ? '...' : '')
    )
  }
}

let victor = new Stringer('Victor', 6)
console.log(victor.toString())

let test = new Stringer('Test', 5)
console.log(test.toString()) // Test

test.decrease(3)
console.log(test.toString()) // Te...

test.decrease(5)
console.log(test.toString()) // ...

test.increase(4)
console.log(test.toString()) // Test
