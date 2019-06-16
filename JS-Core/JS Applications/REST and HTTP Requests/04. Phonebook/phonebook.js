/* global $ */

function attachEvents () {
  const baseUrl = 'https://phonebook-nakov.firebaseio.com/phonebook'
  $('#btnLoad').click(loadContacts)
  $('#btnCreate').click(createContact)

  function createContact () {
    let contact = JSON.stringify({
      person: $('#person').val(),
      phone: $('#phone').val()
    })

    $.ajax({
      method: 'POST',
      url: `${baseUrl}.json`,
      data: contact,
      success: loadContacts,
      error: handleError
    })

    $('#person').val('')
    $('#phone').val('')
  }

  function loadContacts () {
    $.ajax({
      method: 'GET',
      url: `${baseUrl}.json`,
      success: displayContacts,
      error: handleError
    })
  }

  function displayContacts (contacts) {
    $('#phonebook').empty()

    Object
      .entries(contacts)
      .forEach(([id, contact]) => {
        $('<li>')
          .text(`${contact.person}: ${contact.phone} `)
          .append($('<button>')
            .text('Delete')
            .attr('id', id)
            .click(deleteContact))
          .appendTo($('#phonebook'))
      })
  }

  function deleteContact (ev) {
    $.ajax({
      method: 'DELETE',
      url: `${baseUrl}/${ev.target.id}.json`,
      success: loadContacts,
      error: handleError
    })
  }

  function handleError (err) {
    console.log(err)
  }
}
