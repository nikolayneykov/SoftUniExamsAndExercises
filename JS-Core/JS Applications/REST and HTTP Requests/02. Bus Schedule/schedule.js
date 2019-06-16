/* global $ */
function solve () {
  const baseUrl = 'https://judgetests.firebaseio.com/schedule'
  let departBtn = $('#depart')
  let arriveBtn = $('#arrive')
  let info = $('span.info')
  let [id, name] = ['depot', '']

  function depart () {
    $.ajax({
      method: 'GET',
      url: `${baseUrl}/${id}.json`,
      success: loadInfo,
      error: handleError
    })
  }

  function arrive () {
    displayInfo(`Arriving at ${name}`)
  }

  function loadInfo (data) {
    id = data.next
    name = data.name
    displayInfo(`Next stop ${name}`)
  }

  function displayInfo (message) {
    info.empty()
    info.text(message)
    departBtn.attr('disabled', !departBtn.attr('disabled'))
    arriveBtn.attr('disabled', !arriveBtn.attr('disabled'))
  }

  function handleError (err) {
    console.log(err)
    displayInfo('Error')
    departBtn.attr('disabled', true)
    arriveBtn.attr('disabled', true)
  }

  return {
    depart,
    arrive
  }
}
