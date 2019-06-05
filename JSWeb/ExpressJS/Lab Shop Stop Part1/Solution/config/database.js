let products = [
  {
    name: 'Bananas',
    description: 'Buy some bananas',
    price: 3.99,
    image: 'https://www.homebag.bg/media/7/7579.jpg'
  },
  {
    name: 'Apples',
    description: 'Buy some apples',
    price: 3.99,
    image: 'https://cdn1.medicalnewstoday.com/content/images/articles/267290-apples.jpg'
  },
  {
    name: 'Oranges',
    description: 'Buy some oranges',
    price: 3.99,
    image: 'http://www.laceupforchange.org.za/wp-content/uploads/2017/02/fruit-orange.jpg'
  }
]
let count = 1

module.exports.products = {
  getAll () {
    return products
  },
  add (product) {
    product.id = count++
    products.push(product)
  },
  findByName (name) {
    return products.find(p => p.name === name)
  }
}
