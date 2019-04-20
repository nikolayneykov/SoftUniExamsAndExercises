function printArray (params) {
  let [delimeter, arr] = [params.pop(), params]
  console.log(arr.join(delimeter))
}

printArray(['One', 'Two', 'Three', 'Four', 'Five', '-'])
