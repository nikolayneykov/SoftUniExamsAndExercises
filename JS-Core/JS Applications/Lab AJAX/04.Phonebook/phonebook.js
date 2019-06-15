/* global $ */

(() => {
  const baseUrl = 'https://phonebook-ac204.firebaseio.com/'
  const phonebook = $('#phonebook')
  $('#btnLoad').click(loadContacts)
  $('#btnCreate').click(createContact)

  function createContact () {
    let contact = JSON.stringify({
      person: $('#person').val(),
      phone: $('#phone').val()
    })

    $.ajax({
      method: 'POST',
      url: baseUrl + '.json',
      data: contact,
      success: loadContacts,
      error: handleError
    })
  }

  function loadContacts () {
    $.ajax({
      method: 'GET',
      url: baseUrl + '.json',
      success: displayContacts,
      error: handleError
    })
  }

  function deleteContact (ev) {
    $.ajax({
      method: 'DELETE',
      url: baseUrl + `/${ev.target.id}/.json`,
      success: loadContacts,
      error: handleError
    })
  }

  function displayContacts (contacts) {
    phonebook.empty()
    if (!contacts) {
      $('<li>')
        .text('The phonebook is empty...')
        .appendTo(phonebook)
    } else {
      Object.entries(contacts)
        .forEach(([id, contact]) => {
          $('<li>')
            .text(`${contact.person}: ${contact.phone} `)
            .append($('<button>').attr('id', id).text('Delete').click(deleteContact))
            .appendTo(phonebook)
        })
    }
  }

  function handleError (err) {
    console.log(err)
  }
})()
