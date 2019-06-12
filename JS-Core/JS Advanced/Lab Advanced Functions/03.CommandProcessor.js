function solve (params) {
  let commandProcessor = (function () {
    let data = ''

    return {
      append (str) {
        data += str
      },
      removeStart (n) {
        data = data.slice(n)
      },
      removeEnd (n) {
        data = data.slice(0, data.length - n)
      },
      print () {
        console.log(data)
      }
    }
  })()

  params.forEach(param => {
    let [command, arg] = param.split(' ')
    commandProcessor[command](arg)
  })
}

solve(['append hello', 'append again', 'removeStart 3', 'removeEnd 4', 'print'])
