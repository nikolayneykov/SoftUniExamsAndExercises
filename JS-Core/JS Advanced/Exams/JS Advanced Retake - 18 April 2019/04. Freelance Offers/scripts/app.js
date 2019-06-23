/* global $ */

function solution () {
  let createOffers = $('#create-offers')
  let notification = $('#notification')
  let username = $('#username')
  let loginBtn = $('#loginBtn').click(logout)
  loginBtn.click()

  $('#create-offer-Btn').click(createOffer)

  function createOffer (e) {
    e.preventDefault()

    let offerName = $('#offerName')
    let company = $('#company')
    let description = $('#description')

    if (offerName.val() && company.val() && description.val()) {
      $('<div>')
        .addClass('col-3')
        .append($('<div>')
          .addClass('card text-white bg-dark mb-3 pb-3')
          .css('max-width', '18rem')
          .append($('<div>')
            .addClass('card-header')
            .text(offerName.val()))
          .append($('<div>')
            .addClass('card-body')
            .append($('<h5>')
              .addClass('card-title')
              .text(company.val()))
            .append($('<p>')
              .addClass('card-text')
              .text(description.val()))))
        .appendTo('#offers-container')

      offerName.val('')
      company.val('')
      description.val('')
    }
  }

  function login (e) {
    e.preventDefault()
    let name = username.val()

    if (name.length < 4 || name.length > 10) {
      notification.text('The username length should be between 4 and 10 characters.')
    } else {
      notification.text('')
      createOffers.css('display', 'block')
      username.val(`Hello, ${name}!`)
        .addClass('border-0 bg-light')
        .prop('disabled', true)

      loginBtn.text('Logout')
        .off('click', login)
        .click(logout)
    }
  }

  function logout (e) {
    e.preventDefault()
    createOffers.css('display', 'none')
    username.val('')
      .removeClass('border-0 bg-light')
      .prop('disabled', false)

    loginBtn.text('Login')
      .off('click', logout)
      .click(login)
  }
}
