const assert = require('chai').assert

function isSymmetric (arr) {
  if (!Array.isArray(arr)) return false // Non-arrays are non-symmetric
  let reversed = arr.slice(0).reverse() // Clone and reverse
  let equal = JSON.stringify(arr) === JSON.stringify(reversed)
  return equal
}

describe('isSymetric(arr) checks if array is symetrical', () => {
  it('should return false if the input is not an array', () => {
    const input = null
    const value = isSymmetric(input)
    assert.isFalse(value)
  })

  it('should return false for an array of same data types that is not symetrical', () => {
    const input = [1, 2, 3, 4, 5]
    const value = isSymmetric(input)
    assert.isFalse(value)
  })

  it('should return false for an array of different data types that is not symetrical', () => {
    const input = [1, [], {}, true, 'str']
    const value = isSymmetric(input)
    assert.isFalse(value)
  })

  it('should return true for an array of same data types that is symetrical', () => {
    const input = [1, 2, 3, 2, 1]
    const value = isSymmetric(input)
    assert.isTrue(value)
  })

  it('should return true for an array of different data types that is symetrical', () => {
    const input = [[], 5, 'str', {}, true, {}, 'str', 5, []]
    const value = isSymmetric(input)
    assert.isTrue(value)
  })
})
