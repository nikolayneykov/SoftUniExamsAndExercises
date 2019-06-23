/* global $ */

function addProduct () {
  let product = $('input[type="text"]').val()
  let price = +$('input[type="number"]').val()

  if (product && price) {
    $('<tr>')
      .append($('<td>').text(product))
      .append($('<td>').text(price))
      .appendTo($('#product-list'))

    $('tfoot tr td:nth-child(2)')
      .text(+$('tfoot tr td:nth-child(2)').text() + price)

    $('input[type="text"]').val('')
    $('input[type="number"]').val('')
  }
}
