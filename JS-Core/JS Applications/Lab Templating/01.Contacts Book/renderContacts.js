/* global $ Handlebars contacts */
function showDetails (id) {
  $(`#${id}`).toggle()
}

$(async () => {
  try {
    let contactList = await $.get('./contacts-list.hbs')
    let contactCard = await $.get('./contact-card.hbs')

    Handlebars.registerPartial('contactCard', contactCard)
    let contactListTemplate = Handlebars.compile(contactList)
    let contactListHtml = contactListTemplate({ contacts })
    $('body').append(contactListHtml)
  } catch (error) {
    console.log(error)
  }
})
