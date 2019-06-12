function getExtensibleObject () {
  return {
    extend (otherObject) {
      for (let key in otherObject) {
        if (typeof otherObject[key] === 'function') {
          Object.getPrototypeOf(this)[key] = otherObject[key]
        } else {
          this[key] = otherObject[key]
        }
      }
    }
  }
}

// testing the getExtensibleObject function

let extensibleObject = getExtensibleObject()

extensibleObject.extend({
  extensionMethod1: function () {},
  extensionMethod2: function () {},
  extensionMethod3: function () {},
  extensionProperty1: 'someString1',
  extensionProperty2: 'someString2',
  extensionProperty3: 'someString3'
})

// displaying the prototype of the object
console.log(Object.getPrototypeOf(extensibleObject))

// displaying the object
console.log(extensibleObject)
