const assert = require('chai').assert
function sum (arr) {
  let sum = 0
  for (let num of arr) sum += Number(num)
  return sum
}

describe('sum(arr) sums up the numbers from array', () => {
  it('should return positive result for array positive numbers', () => {
    const arr = [1, 2, 3]
    const expected = 6
    const actual = sum(arr)
    assert.strictEqual(actual, expected)
  })

  it('should return negative result for array of negative numbers', () => {
    const arr = [-1, -2, -3]
    const expected = -6
    const actual = sum(arr)
    assert.strictEqual(actual, expected)
  })

  it('should return 0 as result for empty array', () => {
    const arr = []
    const expected = 0
    const actual = sum(arr)
    assert.strictEqual(actual, expected)
  })

  it('should return decimal result for array of decimal numbers', () => {
    const arr = [1.1, 2.2, 3.3]
    const expected = 6.6
    const actual = sum(arr)
    assert.strictEqual(actual, expected)
  })
})
