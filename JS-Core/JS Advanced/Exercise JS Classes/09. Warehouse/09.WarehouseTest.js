const Warehouse = require('./09.Warehouse')
const assert = require('chai').assert
const expect = require('chai').expect

describe('revision() method test', function () {
  let warehouse
  beforeEach(function () {
    warehouse = new Warehouse(5)
  })

  it('should give correct message for empty warehouse', function () {
    expect(warehouse.revision()).to.be.equal('The warehouse is empty')
  })
})
describe('Warehouse', () => {
  describe('constructor', () => {
    it('should throw string if givenSpace <= 0 or non-number argument',
      () => {
        assert.throws(() => new Warehouse(-1))
        assert.throws(() => new Warehouse(0))
        assert.throws(() => new Warehouse('not number'))
      })

    it('should set Warehouse capacty for valid givenSpace', () => {
      let warehouse = new Warehouse(5)
      assert.equal(warehouse.capacity, 5)
      assert.equal(JSON.stringify(warehouse.availableProducts), '{"Food":{},"Drink":{}}')
    })
  })

  describe('addProduct', () => {
    it('should throw string no free space is available', () => {
      let warehouse = new Warehouse(1)
      assert.throws(() => warehouse.addProduct('Food', 'bread', 2))
    })

    it('should add products if has enough free space', () => {
      let warehouse = new Warehouse(4)
      warehouse.addProduct('Food', 'bread', 1)
      warehouse.addProduct('Food', 'potatoes', 1)
      warehouse.addProduct('Drink', 'water', 1)
      warehouse.addProduct('Drink', 'cola', 1)

      assert.hasAllKeys(warehouse.availableProducts.Food, ['bread', 'potatoes'])
      assert.hasAllKeys(warehouse.availableProducts.Drink, ['water', 'cola'])
    })

    it('should return object when adding product successfully', () => {
      let warehouse = new Warehouse(2)
      assert.isObject(warehouse.addProduct('Food', 'bread', 1))
      assert.isObject(warehouse.addProduct('Drink', 'water', 1))
    })
  })

  describe('orderProducts', () => {
    it('should sort foods in descending order by quantity', () => {
      let warehouse = new Warehouse(12)
      warehouse.addProduct('Food', 'bread', 1)
      warehouse.addProduct('Food', 'potatoes', 2)
      warehouse.addProduct('Food', 'mushrooms', 3)
      warehouse.orderProducts('Food')
      let foods = JSON.stringify(warehouse.availableProducts.Food)
      assert.equal(foods, '{"mushrooms":3,"potatoes":2,"bread":1}')
    })

    it('should sort drinks in descending order by quantity', () => {
      let warehouse = new Warehouse(12)
      warehouse.addProduct('Drink', 'water', 1)
      warehouse.addProduct('Drink', 'cola', 2)
      warehouse.addProduct('Drink', 'lemonade', 3)
      warehouse.orderProducts('Drink')
      let drinks = JSON.stringify(warehouse.availableProducts.Drink)
      assert.equal(drinks, '{"lemonade":3,"cola":2,"water":1}')
    })
  })

  describe('occupiedCapacity', () => {
    it('should return a number, which represents the occupied place in the warehouse', () => {
      let warehouse = new Warehouse(10)
      warehouse.addProduct('Food', 'bread', 4)
      assert.equal(warehouse.occupiedCapacity(), 4)
    })
  })

  describe('revision', () => {
    it('should return string "The warehouse is empty" for 0 products', () => {
      let warehouse = new Warehouse(4)
      assert.equal(warehouse.revision(), 'The warehouse is empty')
    })

    it('should return string with all listed products', () => {
      let warehouse = new Warehouse(4)
      warehouse.addProduct('Food', 'bread', 1)
      warehouse.addProduct('Food', 'potatoes', 1)
      warehouse.addProduct('Drink', 'water', 1)
      warehouse.addProduct('Drink', 'cola', 1)

      assert.equal(warehouse.revision(),
        'Product type - [Food]' +
        '\n- bread 1' +
        '\n- potatoes 1' +
        '\nProduct type - [Drink]' +
        '\n- water 1' +
        '\n- cola 1')
    })
  })

  describe('scrapeAProduct', () => {
    it('throw error for non existing type', function () {
      expect(() => {
        let warehouse = new Warehouse(5)
        warehouse.addProduct('Food', 'banana', 4)
        warehouse.addProduct('Food', 'apple', 1)
        warehouse.scrapeAProduct('tomato', 1)
      }).to.throw('tomato do not exists')
    })

    it('should reduce product quantity', () => {
      let warehouse = new Warehouse(10)
      warehouse.addProduct('Food', 'bread', 10)
      warehouse.scrapeAProduct('bread', 9)
      assert.equal(warehouse.availableProducts.Food.bread, 1)
    })

    it('should reduce product quantity', () => {
      let warehouse = new Warehouse(10)
      warehouse.addProduct('Food', 'bread', 10)
      warehouse.scrapeAProduct('bread', 9)
      assert.equal(warehouse.availableProducts.Food.bread, 1)
    })

    it('should reset product quantity if goes below 0', () => {
      let warehouse = new Warehouse(10)
      warehouse.addProduct('Food', 'bread', 10)
      warehouse.scrapeAProduct('bread', 11)
      assert.equal(warehouse.availableProducts.Food.bread, 0)
    })
  })
})
