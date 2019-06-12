function sortedList () {
  const list = []
  return {
    size: 0,
    add (element) {
      list.push(element)
      list.sort((a, b) => a - b)
      this.size++
    },
    remove (index) {
      if (index >= 0 && index < this.size) {
        list.splice(index, 1)
        this.size--
      }
    },
    get (index) {
      return list[index]
    }
  }
}

let myList = sortedList()

myList.add(3)
myList.add(4)
myList.add(5)
myList.add(6)
console.log(myList.size)
