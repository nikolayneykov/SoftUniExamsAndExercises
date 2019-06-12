function solve () {
  let summary = {}

  for (let arg of arguments) {
    let type = typeof arg
    console.log(`${type}: ${arg}`)

    if (!summary.hasOwnProperty(type)) {
      summary[type] = 0
    }

    summary[type]++
  }

  Object.entries(summary)
    .sort((a, b) => b[1] - a[1])
    .forEach(([type, count]) => console.log(`${type} = ${count}`))
}

solve('some string', 3.333, 9.999)
