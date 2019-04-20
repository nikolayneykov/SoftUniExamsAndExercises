function printMatrix (rows, cols) {
  let matrix = []

  for (let i = 0; i < rows; i++) {
    let arr = []
    arr.length = cols
    arr.fill(0)
    matrix.push(arr)
  }

  let direction = 'right'
  let count = 1
  let row = 0
  let col = 0

  while (count <= rows * cols) {
    matrix[row][col] = count

    if (direction === 'right') {
      if (col < matrix[row].length - 1 && matrix[row][col + 1] === 0) {
        col++
      } else {
        direction = 'down'
        row++
      }
    } else if (direction === 'down') {
      if (row < matrix.length - 1 && matrix[row + 1][col] === 0) {
        row++
      } else {
        direction = 'left'
        col--
      }
    } else if (direction === 'left') {
      if (col > 0 && matrix[row][col - 1] === 0) {
        col--
      } else {
        direction = 'up'
        row--
      }
    } else if (direction === 'up') {
      if (row > 0 && matrix[row - 1][col] === 0) {
        row--
      } else {
        direction = 'right'
        col++
      }
    }

    count++
  }

  matrix.forEach(arr => console.log(arr.join(' ')))
}

printMatrix(5, 5)
