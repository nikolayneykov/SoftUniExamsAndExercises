function solve () {
  let str = document.querySelector('#str').value
  let [info, criteria] = str.split(', ')

  let name = info
    .match(/\s([A-Z][A-Za-z]*-([A-Z][A-Za-z]*\.-)?[A-Z][A-Za-z]*)\s/)[1]
    .split('-')
    .join(' ')

  let [fromAirport, toAirport] = info
    .match(/\s([A-Z]{3}\/[A-Z]{3})\s/)[1]
    .split('/')

  let flightNumber = info.match(/\s([A-Z]{1,3}\d{1,5})\s/)[1]

  let company = info
    .match(/-\s([A-Z][A-Za-z]*\*[A-Z][A-Za-z]*)\s/)[1]
    .split('*')
    .join(' ')

  let message = ''

  if (criteria === 'name') {
    message = `Mr/Ms, ${name}, have a nice flight!`
  } else if (criteria === 'flight') {
    message = `Your flight number ${flightNumber} is from ${fromAirport} to ${toAirport}.`
  } else if (criteria === 'company') {
    message = `Have a nice flight with ${company}.`
  } else if (criteria === 'all') {
    message =
      `Mr/Ms, ${name}, your flight number ${flightNumber} ` +
      `is from ${fromAirport} to ${toAirport}. Have a nice flight with ${company}.`
  }

  document.querySelector('#result').textContent = message
}
