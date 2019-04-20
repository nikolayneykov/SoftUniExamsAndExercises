function orbit ([rows, cols, row, col]) {
  let matrix = []
  for (let i = 0; i < rows; i++) {
    let arr = []
    arr.length = cols
    arr.fill(0)
    matrix.push(arr)
  }

  for (let r = 0; r < matrix.length; r++) {
    for (let c = 0; c < matrix[r].length; c++) {
      matrix[r][c] = Math.max(Math.abs(c - col) + 1, Math.abs(r - row) + 1)
    }
  }

  matrix.forEach(arr => console.log(arr.join(' ')))
}

orbit([5, 5, 0, 0])
