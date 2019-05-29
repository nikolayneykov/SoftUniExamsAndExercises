function solve (params) {
  let service = (function () {
    let instructionsList = []
    let parts = {}

    function instructions (model) {
      instructionsList.push(model)
    }

    function addPart (model, [part, serialNumber]) {
      parts[model] = parts[model] || {}
      parts[model][part] = parts[model][part] || []
      parts[model][part].push(serialNumber)
    }

    function repair (model, [carSpecifications]) {
      if (!instructionsList.includes(model)) {
        console.log(`${model} is not supported`)
      } else {
        carSpecifications = JSON.parse(carSpecifications)
        Object.entries(carSpecifications)
          .filter(p => p[1] === 'broken')
          .forEach(p => {
            if (parts[model] && parts[model][p[0]]) {
              carSpecifications[p[0]] = parts[model][p[0]].shift()
            }
          })

        console.log(`${model} client - ${JSON.stringify(carSpecifications)}`)
      }
    }

    function getParts () {
      return parts
    }

    return { instructions, addPart, repair, getParts }
  })()

  params.forEach(p => {
    let [command, model, ...args] = p.split(' ')
    service[command](model, args)
  })

  Object.entries(service.getParts())
    .sort((a, b) => a[0].localeCompare(b[0]))
    .forEach(p => {
      console.log(`${p[0]} - ${JSON.stringify(p[1])}`)
    })
}

solve([
  'instructions bmw',
  'addPart opel engine GV1399SSS',
  'addPart opel transmission SMF556SRG',
  'addPart bmw engine GV1399SSS',
  'addPart bmw transmission SMF444ORG',
  'addPart opel transmission SMF444ORG',
  'instructions opel',
  'repair opel {"engine":"broken","transmission":"OP8766TRS"}',
  'repair bmw {"engine":"ENG999FPH","transmission":"broken","wheels":"broken"}'
])
