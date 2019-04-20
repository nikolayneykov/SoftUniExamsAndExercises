function solve (params) {
  let result = []

  params.slice(1).forEach(param => {
    let [Town, Latitude, Longitude] = param
      .split('|')
      .filter(x => x !== '')
      .map(x => x.trim(' '))

    result.push({ Town, Latitude: +Latitude, Longitude: +Longitude })
  })

  console.log(JSON.stringify(result))
}

solve([
  '| Town | Latitude | Longitude |',
  '| Veliko Turnovo | 43.0757 | 25.6172 |',
  '| Monatevideo | 34.50 | 56.11 |'
])
