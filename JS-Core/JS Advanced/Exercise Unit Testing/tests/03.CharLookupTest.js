const lookupChar = require('../03.CharLookup')
const assert = require('chai').assert

describe('lookupChar() returns character at given index from a string', () => {
  it('should return undefined for ivalid string or index arguments', () => {
    assert.isUndefined(lookupChar(false, 2))
    assert.isUndefined(lookupChar('test', false))
    assert.isUndefined(lookupChar('test', 2.5))
  })

  it('should return "Incorrect index" when index is out of the string range', () => {
    assert.equal(lookupChar('test', -1), 'Incorrect index')
    assert.equal(lookupChar('test', 5), 'Incorrect index')
  })

  it('should return the character from the string to the corresponding index', () => {
    assert.equal(lookupChar('test', 0), 't')
    assert.equal(lookupChar('test', 1), 'e')
    assert.equal(lookupChar('test', 2), 's')
    assert.equal(lookupChar('test', 3), 't')
  })
})
