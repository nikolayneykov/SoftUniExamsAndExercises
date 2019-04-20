function solve () {
  let [targetThickness, ...chunks] = JSON.parse(
    document.getElementById('arr').value
  ).map(Number)
  let result = document.getElementById('result')

  let operationCount = 0
  let cut = chunk => (chunk /= 4)
  let lap = chunk => (chunk *= 0.8)
  let grind = chunk => (chunk -= 20)
  let etch = chunk => (chunk -= 2)
  let xray = chunk => (chunk += 1)
  let wash = chunk => Math.floor(chunk)

  let printMessage = message => {
    let p = document.createElement('p')
    p.textContent = message
    result.appendChild(p)
  }

  chunks.forEach(chunk => {
    printMessage(`Processing chunk ${chunk} microns`)

    if (cut(chunk) >= targetThickness) {
      while (cut(chunk) >= targetThickness) {
        chunk = cut(chunk)
        operationCount++
      }

      printMessage(`Cut x${operationCount}`)
      printMessage('Transporting and washing')
      operationCount = 0
      chunk = wash(chunk)
    }

    if (lap(chunk) >= targetThickness) {
      while (lap(chunk) >= targetThickness) {
        chunk = lap(chunk)
        operationCount++
      }

      printMessage(`Lap x${operationCount}`)
      printMessage('Transporting and washing')
      operationCount = 0
      chunk = wash(chunk)
    }

    if (grind(chunk) >= targetThickness) {
      while (grind(chunk) >= targetThickness) {
        chunk = grind(chunk)
        operationCount++
      }

      printMessage(`Grind x${operationCount}`)
      printMessage('Transporting and washing')
      operationCount = 0
      chunk = wash(chunk)
    }

    if (etch(chunk) >= targetThickness) {
      while (chunk > targetThickness) {
        chunk = etch(chunk)
        operationCount++
      }

      printMessage(`Etch x${operationCount}`)
      printMessage('Transporting and washing')
      operationCount = 0
      chunk = wash(chunk)
    }

    if (chunk < targetThickness) {
      operationCount++
      printMessage(`X-ray x${operationCount}`)
      operationCount = 0
      chunk = xray(chunk)
    }

    printMessage(`Finished crystal ${chunk} microns`)
  })
}
