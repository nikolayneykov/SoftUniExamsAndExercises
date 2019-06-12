function subsum (arr, startIndex, endIndex) {
  if (!Array.isArray(arr) || arr.some(x => isNaN(x))) {
    return NaN
  }

  startIndex = Math.max(0, startIndex)
  endIndex = Math.min(arr.length, endIndex + 1)
  let sum = arr.slice(startIndex, endIndex).reduce((acc, e) => acc + e, 0)

  return sum
}

console.log(subsum([10, 20, 30, 40, 50, 60], 3, 300))
console.log(subsum([1.1, 2.2, 3.3, 4.4, 5.5], -3, 1))
console.log(subsum([10, 'twenty', 30, 40], 0, 2))
console.log(subsum([], 1, 2))
console.log(subsum('text', 0, 2))
