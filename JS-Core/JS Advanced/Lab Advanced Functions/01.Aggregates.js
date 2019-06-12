function solution (arr) {
  let sum = arr.reduce((a, b) => a + b, 0)
  let min = arr.reduce((a, b) => Math.min(a, b))
  let max = arr.reduce((a, b) => Math.max(a, b))
  let product = arr.reduce((a, b) => a * b)
  let join = arr.reduce((a, b) => a + b, '')
  let result =
    `Sum: ${sum}\nMin = ${min}\nMax = ${max}\n` +
    `Product = ${product}\nJoin = ${join}`

  console.log(result)
}

solution([2, 3, 10, 5])
