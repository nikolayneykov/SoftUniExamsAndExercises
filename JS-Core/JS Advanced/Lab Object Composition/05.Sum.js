/* global $ */
$(() => {
  // Judge requires only the getModel function
  function getModel () {
    let num1, num2, result
    let init = (selector1, selector2, selectorResult) => {
      num1 = $(selector1)
      num2 = $(selector2)
      result = $(selectorResult)
    }

    let add = () => {
      result.val(Number(num1.val()) + Number(num2.val()))
    }

    let subtract = () => {
      result.val(Number(num1.val()) - Number(num2.val()))
    }

    return { init, add, subtract }
  }

  let model = getModel()
  model.init('#num1', '#num2', '#result')

  $('#sumButton').click(model.add)
  $('#subtractButton').click(model.subtract)
})
