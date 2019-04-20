function isMagixMatrix (matrix) {
  let sum = matrix[0].reduce((a, b) => a + b, 0)
  let isMagic = true

  matrix.forEach((row, index) => {
    let horizontalSum = row.reduce((a, b) => a + b, 0)
    let verticalSum = matrix.map(arr => arr[index]).reduce((a, b) => a + b, 0)

    if (horizontalSum !== sum || verticalSum !== sum) {
      isMagic = false
    }
  })

  console.log(isMagic)
}

isMagixMatrix([[4, 5, 6], [6, 5, 4], [5, 5, 5]])
