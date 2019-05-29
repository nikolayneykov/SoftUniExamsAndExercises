function solve (arr, num) {
  let [damagePerHit, stopNumber, rounds] = [
    Math.min(...arr),
    Math.max(...arr),
    1
  ]

  let [firstArr, secondArr] = [
    arr.slice(0, arr.length / 2),
    arr.slice(arr.length / 2)
  ]
  let [firstGiant, secondGiant] = [0, 0]

  while (firstArr.length > 0 && secondArr.length > 0) {
    firstGiant += firstArr.splice(0, num).reduce((acc, el) => acc * el)
    secondGiant += secondArr.splice(-num, num).reduce((acc, el) => acc * el)
  }

  if (damagePerHit !== 0) {
    while (firstGiant > stopNumber && secondGiant > stopNumber) {
      firstGiant -= damagePerHit
      secondGiant -= damagePerHit
      rounds++
    }
  }

  console.log(
    firstGiant === secondGiant
      ? `Its a draw ${firstGiant} - ${secondGiant}`
      : firstGiant > secondGiant
        ? `First Giant defeated Second Giant with result ${firstGiant} - ${secondGiant} in ${rounds} rounds`
        : `Second Giant defeated First Giant with result ${secondGiant} - ${firstGiant} in ${rounds} rounds`
  )
}

solve([3, 3, 3, 4, 5, 6, 7, 8, 9, 10, 5, 4], 2)
