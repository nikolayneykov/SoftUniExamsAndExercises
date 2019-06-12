const mathEnforcer = require('../04.MathEnforcer')
const assert = require('chai').assert

describe('mathEnforcer', () => {
  describe('addFive', () => {
    it('should return undefined with non-number input', () => {
      assert.isUndefined(mathEnforcer.addFive('8'))
    })

    it('should return the input number plus 5', () => {
      assert.equal(mathEnforcer.addFive(0), 5)
      assert.equal(mathEnforcer.addFive(-10), -5)
      assert.closeTo(mathEnforcer.addFive(3.14), 8.14, 0.01)
    })
  })

  describe('subtractTen', () => {
    it('should return undefined with non-number input', () => {
      assert.isUndefined(mathEnforcer.subtractTen('5'))
    })

    it('should return the input number minus 10', () => {
      assert.equal(mathEnforcer.subtractTen(10), 0)
      assert.equal(mathEnforcer.subtractTen(-5), -15)
      assert.closeTo(mathEnforcer.subtractTen(3.14), -6.86, 0.01)
    })
  })

  describe('sum', () => {
    it('should return undefined with non-number input', () => {
      assert.isUndefined(mathEnforcer.sum('8', 5))
      assert.isUndefined(mathEnforcer.sum(5, '8'))
    })

    it('should return the sum of two numbers', () => {
      assert.equal(mathEnforcer.sum(5, 5), 10)
      assert.equal(mathEnforcer.sum(-3, 5), 2)
      assert.closeTo(mathEnforcer.sum(2.7, 3.4), 6.1, 0.01)
    })
  })
})
