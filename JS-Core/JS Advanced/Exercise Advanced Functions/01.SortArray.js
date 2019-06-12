function solve (arr, criteria) {
  let sortingOrder = {
    asc (a, b) {
      return a - b
    },
    desc (a, b) {
      return b - a
    }
  }

  return arr.sort(sortingOrder[criteria])
}

solve([14, 7, 17, 6, 8], 'asc')
