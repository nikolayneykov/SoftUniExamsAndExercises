function solve () {
  let data = ''
  return {
    append (str) {
      data += str
    },
    removeStart (n) {
      data = data.slice(n)
    },
    removeEnd (n) {
      data = data.slice(0, data.length - n)
    },
    print () {
      console.log(data)
    }
  }
}
