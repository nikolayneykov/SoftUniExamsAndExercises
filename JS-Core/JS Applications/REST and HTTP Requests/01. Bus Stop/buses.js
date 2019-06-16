/* global $ */
function getInfo () {
  let baseUrl = `https://judgetests.firebaseio.com/businfo`
  let stopName = $('#stopName')
  let buses = $('#buses')
  let stopId = $('#stopId').val()

  $.ajax({
    method: 'GET',
    url: baseUrl + `/${stopId}.json`,
    success: loadStops,
    error: handleError
  })

  function loadStops (stop) {
    stopName.empty()
    buses.empty()
    stopName.text(stop.name)

    Object
      .entries(stop.buses)
      .forEach(([busId, time]) => {
        buses
          .append($('<li>')
            .text(`Bus ${busId} arrives in ${time} minutes`))
      })
  }

  function handleError (err) {
    console.log(err)
    stopName.empty()
    buses.empty()
    stopName.text('Error')
  }
}
