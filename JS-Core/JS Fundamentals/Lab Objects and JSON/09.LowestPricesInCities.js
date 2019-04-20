function solve (arr) {
  let products = {}

  arr.forEach(line => {
    let [town, product, price] = line.split(' | ')

    if (!products.hasOwnProperty(product)) {
      products[product] = {}
    }

    products[product][town] = +price
  })

  for (let product in products) {
    let [town, price] = Object.entries(products[product]).sort(
      (a, b) => a[1] - b[1]
    )[0]

    console.log(`${product} -> ${price} (${town})`)
  }
}

solve([
  'Sofia City | Audi | 100000',
  'Sofia City | BMW | 100000',
  'Sofia City | Mitsubishi | 10000',
  'Sofia City | Mercedes | 10000',
  'Sofia City | NoOffenseToCarLovers | 0',
  'Mexico City | Audi | 1000',
  'Mexico City | BMW | 99999',
  'New York City | Mitsubishi | 10000',
  'New York City | Mitsubishi | 1000',
  'Mexico City | Audi | 100000',
  'Washington City | Mercedes | 1000'
])
