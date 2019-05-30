function solve (arr) {
  let [towns, profits] = [{}, {}]

  arr.forEach(vehicule => {
    if (!towns.hasOwnProperty(vehicule.town)) {
      towns[vehicule.town] = {}
      profits[vehicule.town] = {
        profit: 0,
        registered: 0
      }
    }

    if (!towns[vehicule.town].hasOwnProperty(vehicule.model)) {
      towns[vehicule.town][vehicule.model] = {
        regNumbers: [],
        price: vehicule.price
      }
    }

    towns[vehicule.town][vehicule.model].regNumbers.push(vehicule.regNumber)
    profits[vehicule.town].profit += vehicule.price
    profits[vehicule.town].registered++
  })

  let [town, data] = Object.entries(profits).sort(
    (a, b) =>
      b[1].profit - a[1].profit ||
      b[1].registred - a[1].registred ||
      a[0].localeCompare(b[0])
  )[0]
  console.log(`${town} is most profitable - ${data.profit} BGN`)

  let [model] = Object.entries(towns[town]).sort(
    (a, b) =>
      b[1].regNumbers.length - a[1].regNumbers.length ||
      b[1].price - a[1].price ||
      a[0].localeCompare(b[0])
  )[0]
  console.log(`Most driven model: ${model}`)

  Object.entries(towns)
    .filter(t => t[1].hasOwnProperty(model))
    .sort((a, b) => a[0].localeCompare(b[0]))
    .forEach(t => {
      let regNumbers = t[1][model].regNumbers
        .sort((a, b) => a.localeCompare(b))
        .join(', ')

      console.log(`${t[0]}: ${regNumbers}`)
    })
}

solve([
  { model: 'BMW', regNumber: 'B1234SM', town: 'Varna', price: 2 },
  { model: 'BMW', regNumber: 'C5959CZ', town: 'Sofia', price: 8 },
  { model: 'Tesla', regNumber: 'NIKOLA', town: 'Burgas', price: 9 },
  { model: 'BMW', regNumber: 'A3423SM', town: 'Varna', price: 3 },
  { model: 'Lada', regNumber: 'SJSCA', town: 'Sofia', price: 3 }
])
