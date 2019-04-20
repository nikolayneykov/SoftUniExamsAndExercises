function modifyArray (params) {
  let arr = []
  let count = 1

  params.forEach(command => {
    command === 'add' ? arr.push(count) : arr.pop()
    count++
  })

  console.log(arr.length > 0 ? arr.join('\n') : 'Empty')
}

modifyArray(['add', 'add', 'remove', 'add', 'add'])
