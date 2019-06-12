const PaymentPackage = require('../08.PaymentPackage')
const assert = require('chai').assert

describe('PaymentPackage', () => {
  let paymentPackage = null
  beforeEach(() => {
    paymentPackage = new PaymentPackage('test', 100)
  })

  describe('name', () => {
    it('should be throw error for non-string', () => {
      assert.throws(() => (paymentPackage.name = false))
    })

    it('should be throw error for empty string', () => {
      assert.throws(() => (paymentPackage.name = ''))
    })

    it('should set the value of the name', () => {
      paymentPackage.name = 'John'
      assert.equal(paymentPackage.name, 'John')
    })
  })

  describe('value', () => {
    it('should be throw error for non-number', () => {
      assert.throws(() => (paymentPackage.value = false))
    })

    it('should be throw error for negative number', () => {
      assert.throws(() => (paymentPackage.value = -1))
    })

    it('should set the value of the value property', () => {
      paymentPackage.value = 200
      assert.equal(paymentPackage.value, 200)
    })

    it('should work with value of 0', () => {
      paymentPackage.value = 0
      assert.equal(paymentPackage.value, 0)
    })
  })

  describe('VAT', () => {
    it('should be throw error for non-number', () => {
      assert.throws(() => (paymentPackage.VAT = false))
    })

    it('should be throw error for negative number', () => {
      assert.throws(() => (paymentPackage.VAT = -1))
    })

    it('should be with value 20 by default', () => {
      assert.equal(paymentPackage.VAT, 20)
    })

    it('should set the value of the VAT property', () => {
      paymentPackage.VAT = 200
      assert.equal(paymentPackage.VAT, 200)
    })
  })

  describe('active', () => {
    it('should be throw error for non-boolean', () => {
      assert.throws(() => (paymentPackage.active = 'invalid'))
    })

    it('should be true by default', () => {
      assert.isTrue(paymentPackage.active)
    })

    it('should set the value active property', () => {
      paymentPackage.active = false
      assert.isFalse(paymentPackage.active)
    })
  })

  describe('toString()', () => {
    it('should print package info', () => {
      let expected =
        'Package: test\n- Value (excl. VAT): 100\n- Value (VAT 20%): 120'

      assert.equal(paymentPackage.toString(), expected)
    })

    it('should attach inactive label when active is false', () => {
      paymentPackage.active = false
      let expected =
        'Package: test (inactive)\n- Value (excl. VAT): 100\n- Value (VAT 20%): 120'

      assert.equal(paymentPackage.toString(), expected)
    })
  })
})
