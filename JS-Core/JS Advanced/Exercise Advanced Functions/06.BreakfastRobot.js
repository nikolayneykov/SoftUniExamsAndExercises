function solution (params) {
  return (function () {
    const storage = { protein: 0, carbohydrate: 0, fat: 0, flavour: 0 }
    const recipesLibrary = {
      apple: { carbohydrate: 1, flavour: 2 },
      lemonade: { carbohydrate: 10, flavour: 20 },
      burger: { carbohydrate: 5, fat: 7, flavour: 3 },
      eggs: { protein: 5, fat: 1, flavour: 1 },
      turkey: { protein: 10, carbohydrate: 10, fat: 10, flavour: 10 }
    }

    return input => {
      let [command, ...args] = input.split(' ')
      let message = ''

      if (command === 'restock') {
        let [microelement, quantity] = [args[0], +args[1]]
        storage[microelement] += quantity
        message = 'Success'
      } else if (command === 'prepare') {
        let [recipe, quantity] = [args[0], +args[1]]
        let missingIngredient = Object.entries(recipesLibrary[recipe]).find(
          ([name, requiredQuantity]) =>
            storage[name] < requiredQuantity * quantity
        )

        if (missingIngredient) {
          message = `Error: not enough ${missingIngredient[0]} in stock`
        } else {
          for (let ingredient in recipesLibrary[recipe]) {
            storage[ingredient] -= recipesLibrary[recipe][ingredient] * quantity
          }

          message = 'Success'
        }
      } else if (command === 'report') {
        message =
          `protein=${storage.protein} carbohydrate=${storage.carbohydrate}` +
          ` fat=${storage.fat} flavour=${storage.flavour}`
      }

      console.log(message)
      return message
    }
  })()
}
