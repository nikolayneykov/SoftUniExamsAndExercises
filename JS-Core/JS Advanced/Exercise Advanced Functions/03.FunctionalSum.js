let solve = (function () {
  let sum = 0

  function add (num) {
    sum += num
    return add
  }

  add.toString = function () {
    return sum
  }

  return add
})()

console.log(solve(5)(10)(23).toString())

// judge requires only the IFFE (without the let solve variable)
