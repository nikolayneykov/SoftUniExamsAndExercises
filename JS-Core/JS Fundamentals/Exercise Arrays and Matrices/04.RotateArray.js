function rotate (params) {
  let [count, arr] = [params.pop() % params.length, params]

  while (count > 0) {
    arr.unshift(arr.pop())
    count--
  }

  console.log(arr.join(' '))
}

rotate(['1', '2', '3', '4', '2'])
