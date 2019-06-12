;(function () {
  String.prototype.ensureStart = function (str) {
    return this.startsWith(str) ? this.toString() : str + this
  }

  String.prototype.ensureEnd = function (str) {
    return this.endsWith(str) ? this.toString() : this + str
  }

  String.prototype.isEmpty = function () {
    return this.length === 0
  }

  String.prototype.truncate = function (n) {
    if (n < 4) {
      return '.'.repeat(n)
    }

    if (this.length <= n) {
      return this.toString()
    }

    let index = this.toString()
      .substr(0, n - 2)
      .lastIndexOf(' ')

    return index === -1 ? `${this.substr(0, n - 3)}...` : `${this.substr(0, index)}...`
  }

  String.format = function (str, ...params) {
    params.forEach((p, i) => (str = str.replace(`{${i}}`, p)))
    return str.toString()
  }
})()

let str = 'my string'
str = str.ensureStart('my')
str = str.ensureStart('hello ')
str = str.truncate(16)
str = str.truncate(14)
str = str.truncate(8)
str = str.truncate(4)
str = str.truncate(2)
console.log(str)

str = String.format('The {0} {1} fox', 'quick', 'brown')
console.log(str)
str = String.format('jumps {0} {1}', 'dog')
console.log(str)
