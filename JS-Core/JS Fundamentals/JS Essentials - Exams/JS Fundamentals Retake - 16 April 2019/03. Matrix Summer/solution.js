function solve (matrix1, matrix2) {
  let result = []

  for (let row = 0; row < matrix1.length; row++) {
    result.push([])
    let remainder = 0

    for (let col = 0; col < matrix1[row].length; col++) {
      let sum = matrix1[row][col] + matrix2[row][col] + remainder
      result[row][col] = sum <= 9 ? sum : 9
      remainder = sum <= 9 ? 0 : sum - 9
    }

    while (remainder > 0) {
      result[row].push(remainder <= 9 ? remainder : 9)
      remainder -= 9
    }
  }

  console.log(JSON.stringify(result))
}

solve([[9, 9], [4, 7]], [[7, 1], [1, 2]])
