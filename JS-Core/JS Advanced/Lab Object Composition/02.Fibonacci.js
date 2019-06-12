function getFibonator () {
  let [f1, f2] = [0, 1]

  return () => {
    [f1, f2] = [f2, f1 + f2]
    return f1
  }
}

let fib = getFibonator()
console.log(fib()) // 1
console.log(fib()) // 1
console.log(fib()) // 2
console.log(fib()) // 3
console.log(fib()) // 5
console.log(fib()) // 8
console.log(fib()) // 13
