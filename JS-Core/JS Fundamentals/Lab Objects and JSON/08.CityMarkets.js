function solve (params) {
  let towns = {}

  params
    .map(x => x.split(/\s->\s|\s:\s/g))
    .forEach(([town, product, amountOfSales, priceForOneUnit]) => {
      if (!towns.hasOwnProperty(town)) {
        towns[town] = {}
      }

      if (!towns[town].hasOwnProperty(product)) {
        towns[town][product] = 0
      }

      towns[town][product] += amountOfSales * priceForOneUnit
    })

  for (let town in towns) {
    console.log(`Town - ${town}`)

    for (let product in towns[town]) {
      console.log(`$$$${product} : ${towns[town][product]}`)
    }
  }
}

solve([
  'Sofia -> Laptops HP -> 200 : 2000',
  'Sofia -> Raspberry -> 200000 : 1500',
  'Sofia -> Audi Q7 -> 200 : 100000',
  'Montana -> Portokals -> 200000 : 1',
  'Montana -> Qgodas -> 20000 : 0.2',
  'Montana -> Chereshas -> 1000 : 0.3'
])
