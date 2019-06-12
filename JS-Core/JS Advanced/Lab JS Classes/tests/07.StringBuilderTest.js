const StringBuilder = require('../07.StringBuilder')
const assert = require('chai').assert

describe('StringBuilder', () => {
  let sb = null
  beforeEach(() => {
    sb = new StringBuilder('test')
  })

  describe('methods', () => {
    it('should have methods to manipulate the string', () => {
      let methods = ['append', 'prepend', 'insertAt', 'remove', 'toString']
      methods.every(m => assert.isFunction(StringBuilder.prototype[m]))
    })
  })

  describe('instantiating', () => {
    it('should be instantiated without argument', () => {
      sb = new StringBuilder()
      assert.isObject(sb)
    })

    it('should be instantiated with argument', () => {
      assert.isObject(sb)
    })
  })

  describe('append', () => {
    it('should add the argument to the end of the storage', () => {
      sb.append(' appended')
      assert.equal(sb.toString(), 'test appended')
    })
  })

  describe('prepend', () => {
    it('should add the argument at the begining of the storage', () => {
      sb.prepend('prepended ')
      assert.equal(sb.toString(), 'prepended test')
    })
  })

  describe('insertAt', () => {
    it('should insert argument at given index', () => {
      sb.insertAt(' inserted ', 2)
      assert.equal(sb.toString(), 'te inserted st')
    })

    it('should have the same strings', () => {
      sb = new StringBuilder('test')
      sb.insertAt('str', 0)
      let source = sb._stringArray
      let expected = Array.from('test')
      expected.splice(0, 0, ...'str')

      for (let i = 0; i < source.length; i++) {
        assert.equal(source[i], expected[i])
      }
    })
  })

  describe('remove', () => {
    it('should remove number of characters starting from a given index', () => {
      sb.remove(1, 2)
      assert.equal(sb.toString(), 'tt')
    })
  })

  describe('toString', () => {
    it('should return string', () => {
      assert.isString(sb.toString())
    })

    it('should throw error for nonstring argument', () => {
      assert.throws(() => sb.append(false))
    })
  })
})
