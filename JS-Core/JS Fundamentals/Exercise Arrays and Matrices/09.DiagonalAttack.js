function diagonalAttack (params) {
  let matrix = params.map(x => x.split(' ').map(Number))
  let leftSum = 0
  let rightSum = 0
  let leftCol = 0
  let rightCol = matrix[0].length - 1
  let coords = []

  for (let row = 0; row < matrix.length; row++, leftCol++, rightCol--) {
    leftSum += matrix[row][leftCol]
    rightSum += matrix[row][rightCol]
    coords.push(`row: ${row} col: ${leftCol}`)
    coords.push(`row: ${row} col: ${rightCol}`)
  }

  if (leftSum === rightSum) {
    for (let row = 0; row < matrix.length; row++) {
      for (let col = 0; col < matrix[row].length; col++) {
        if (!coords.includes(`row: ${row} col: ${col}`)) {
          matrix[row][col] = leftSum
        }
      }
    }
  }

  matrix.forEach(arr => console.log(arr.join(' ')))
}

diagonalAttack([
  '5 3 12 3 1',
  '11 4 23 2 5',
  '101 12 3 21 10',
  '1 4 5 2 2',
  '5 22 33 11 1'
])
