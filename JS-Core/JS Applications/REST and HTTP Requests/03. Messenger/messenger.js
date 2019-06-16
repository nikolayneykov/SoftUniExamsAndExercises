/* global $ */

function attachEvents () {
  const baseUrl = 'https://messenger-16775.firebaseio.com/messenger.json'
  $('#submit').click(sendMessage)
  $('#refresh').click(refreshMessages)

  function refreshMessages () {
    $.ajax({
      method: 'GET',
      url: baseUrl,
      success: displayMessages,
      error: handleError
    })
  }

  function sendMessage () {
    let message = JSON.stringify({
      author: $('#author').val(),
      content: $('#content').val(),
      timestamp: Date.now()
    })

    $.ajax({
      method: 'POST',
      url: baseUrl,
      data: message,
      success: refreshMessages,
      error: handleError
    })

    $('#author').val('')
    $('#content').val('')
  }

  function displayMessages (data) {
    $('#messages')
      .text(
        Object.values(data)
          .sort((a, b) => a.timestamp - b.timestamp)
          .map(m => `${m.author}: ${m.content}`)
          .join('\n')
      )
  }

  function handleError (err) {
    console.log(err)
  }
}
