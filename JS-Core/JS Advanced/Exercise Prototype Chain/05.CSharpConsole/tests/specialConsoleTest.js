const Console = require('../specialConsole')
const assert = require('chai').assert
const expect = require('chai').expect

describe('Console writeLine method', () => {
  it('should return the same string for single string argument', () => {
    let str = 'Hi'
    assert.equal(Console.writeLine(str), str)
  })

  it('should return JSON string for single object argument', () => {
    let obj = { name: 'test' }
    assert.equal(Console.writeLine(obj), JSON.stringify(obj))
  })

  it(
    'should throw a TypeError for multiple arguments ' +
      'if first argument is not a string',
    () => {
      let firstArg = false
      let secondArg = 'test'
      assert.throws(() => Console.writeLine(firstArg, secondArg), TypeError)
    }
  )

  it(
    'should throw RangeError if the count of the arguments ' +
      'does not correspond to the count of placeholders',
    () => {
      assert.throws(
        () => Console.writeLine('The sum of {0} and {1} is {2}', 3, 4),
        RangeError
      )
    }
  )

  it(
    'should throw RangeError' +
      ' if the placeholders have indexes not withing the parameters range ',
    () => {
      assert.throws(() => Console.writeLine('Not {10}', 'valid'), RangeError)
    }
  )

  it('should replace the placeholders with the corresponding arguments', () => {
    let expected = 'The sum of 3 and 4 is 7'
    let actual = Console.writeLine('The sum of {0} and {1} is {2}', 3, 4, 7)
    assert.equal(actual, expected)
  })
})
