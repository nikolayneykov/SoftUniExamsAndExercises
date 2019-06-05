const fs = require('fs')
const path = require('path')
const dbPath = path.join(__dirname, './database.json')

function getProducts () {
  if (!fs.existsSync(dbPath)) {
    fs.writeFileSync(dbPath, '[]')
    return []
  }

  let products = fs.readFileSync(dbPath).toString() || '[]'
  return JSON.parse(products)
}

function saveProducts (products) {
  fs.writeFileSync(dbPath, JSON.stringify(products))
}

module.exports.products = {
  getAll () {
    return getProducts()
  },
  add (product) {
    let products = getProducts()
    product.id = getProducts.length + 1
    products.push(product)
    saveProducts(products)
  },
  findByName (name) {
    return getProducts().filter(p =>
      p.name.toLowerCase().includes(name.toLowerCase())
    )
  }
}
