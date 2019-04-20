function solve () {
  let input = JSON.parse(document.querySelector('#arr').value)
  let result = document.querySelector('#result')

  let cars = {}
  input.forEach(car => {
    let category = ''

    if (/^BA \d{3} \d{3}$/.test(car)) {
      category = 'BulgarianArmy'
    } else if (/^CP \d{2} \d{3}$/.test(car)) {
      category = 'CivilProtection'
    } else if (/^(C|CT) \d{4}$/.test(car)) {
      category = 'Diplomatic'
    } else if (/^XX \d{4}$/.test(car)) {
      category = 'Foreigners'
    } else if (/^\d{3} [A-Za-z] \d{3}$/.test(car)) {
      category = 'Transient'
    } else if (/^(C|CA|CB) \d{4} [A-Za-z]{1,2}$/.test(car)) {
      category = 'Sofia'
    } else if (/^[A-Za-z]{1,2} \d{4} [A-Za-z]{1,2}$/.test(car)) {
      category = 'Province'
    } else {
      category = 'Other'
    }

    if (!cars.hasOwnProperty(category)) {
      cars[category] = 0
    }

    cars[category]++
  })

  Object.entries(cars)
    .sort((a, b) => a[0].localeCompare(b[0]))
    .forEach(([category, count]) => {
      let p = document.createElement('p')
      p.textContent = `${category} -> ${count}`
      result.appendChild(p)
    })
}
