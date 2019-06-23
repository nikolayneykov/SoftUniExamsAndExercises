/* global $ */

function acceptance () {
  let warehouse = $('#warehouse')
  let shippingCompany = $('[name="shippingCompany"]')
  let productName = $('[name="productName"]')
  let productQuantity = $('[name="productQuantity"]')
  let productScrape = $('[name="productScrape"]')

  $('#acceptance').click(addProduct)

  function addProduct () {
    let company = shippingCompany.val()
    let product = productName.val()
    let quantity = +productQuantity.val() - +productScrape.val()
    console.log(productQuantity.val())
    console.log(productScrape.val())

    if (company && product && quantity > 0) {
      $('<div>')
        .append($('<p>')
          .text(`[${company}] ` +
            `${product} - ` +
            `${quantity} pieces`))
        .append($('<button>')
          .attr('type', 'button')
          .text('Out of stock')
          .click((ev) => $(ev.target).parent().remove()))
        .appendTo(warehouse)

      shippingCompany.val('')
      productName.val('')
      productQuantity.val('')
      productScrape.val('')
    }
  }
}
