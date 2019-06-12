(function () {
  let id = 0

  function Extends (template) {
    this.id = id++
  }

  Extends.prototype.extend = function (template) {
    for (let key in template) {
      if (typeof template[key] === 'function') {
        Object.getPrototypeOf(this)[key] = template[key]
      } else {
        this[key] = template[key]
      }
    }
  }

  return Extends
})()
