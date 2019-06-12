const isOddOrEven = require('../02.EvenOrOdd')
const assert = require('chai').assert

describe('isODOrEven', () => {
  it('should return undefined for non string arguments', () => {
    assert.isUndefined(isOddOrEven(2))
    assert.isUndefined(isOddOrEven({}))
    assert.isUndefined(isOddOrEven([]))
    assert.isUndefined(isOddOrEven(() => {}))
    assert.isUndefined(isOddOrEven(true))
  })

  it('should return "even" for string with even length', () => {
    assert.equal(isOddOrEven(''), 'even')
    assert.equal(isOddOrEven('ab'), 'even')
    assert.equal(isOddOrEven('abcd'), 'even')
  })

  it('should return "odd" for string with even length', () => {
    assert.equal(isOddOrEven('a'), 'odd')
    assert.equal(isOddOrEven('abc'), 'odd')
    assert.equal(isOddOrEven('abcde'), 'odd')
  })
})
