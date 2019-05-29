function coffeeStorage () {
  let input = JSON.parse(document.querySelector('textarea').value)
  let [reportOutput, inspectionOutput] = document.querySelectorAll('div p')

  let storage = (function () {
    let storedCoffee = {}

    function report () {
      for (let brand in storedCoffee) {
        reportOutput.innerHTML += `${brand}:`
        for (let name in storedCoffee[brand]) {
          reportOutput.innerHTML += ` ${name} - ${
            storedCoffee[brand][name].expireDate
          } - ${storedCoffee[brand][name].quantity}.`
        }

        reportOutput.innerHTML += '<br>'
      }
    }

    function inspection () {
      Object.keys(storedCoffee)
        .sort((a, b) => a.localeCompare(b))
        .forEach(brand => {
          inspectionOutput.innerHTML += `${brand}:`
          Object.keys(storedCoffee[brand])
            .sort(
              (a, b) =>
                storedCoffee[brand][b].quantity -
                storedCoffee[brand][a].quantity
            )
            .forEach(coffeeKey => {
              let coffee = storedCoffee[brand][coffeeKey]
              inspectionOutput.innerHTML += ` ${coffee.name} - ${
                coffee.expireDate
              } - ${coffee.quantity}.`
            })

          inspectionOutput.innerHTML += '<br>'
        })
    }

    function addCoffee (brand, name, expireDate, quantity) {
      if (!storedCoffee.hasOwnProperty(brand)) {
        storedCoffee[brand] = {}
      }

      if (!storedCoffee[brand].hasOwnProperty(name)) {
        storedCoffee[brand][name] = {
          name,
          expireDate,
          quantity
        }
      } else {
        let currentCoffee = storedCoffee[brand][name]
        if (currentCoffee.expireDate < expireDate) {
          currentCoffee.expireDate = expireDate
          currentCoffee.quantity = quantity
        } else if (currentCoffee.expireDate === expireDate) {
          currentCoffee.quantity += quantity
        }
      }
    }

    function removeCoffee (brand, name, expireDate, quantity) {
      if (
        storedCoffee.hasOwnProperty(brand) &&
        storedCoffee[brand].hasOwnProperty(name)
      ) {
        let currentCoffee = storedCoffee[brand][name]
        if (
          currentCoffee.expireDate > expireDate &&
          currentCoffee.quantity >= quantity
        ) {
          currentCoffee.quantity -= quantity
        }
      }
    }

    return { in: addCoffee, out: removeCoffee, report, inspection }
  })()

  input.forEach(x => {
    let [command, brand, name, expireDate, quantity] = x.split(', ')
    storage[command.toLowerCase()](brand, name, expireDate, quantity)
  })
}
