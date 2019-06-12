function attachEventsListeners () {
  let days = document.querySelector('#days')
  let hours = document.querySelector('#hours')
  let minutes = document.querySelector('#minutes')
  let seconds = document.querySelector('#seconds')

  Array.from(document.querySelectorAll('input[type="button"]')).forEach(b =>
    b.addEventListener('click', convert)
  )

  function convert (ev) {
    let totalSeconds = seconds.value

    switch (ev.target.id) {
      case 'daysBtn':
        totalSeconds = days.value * 86400
        break
      case 'hoursBtn':
        totalSeconds = hours.value * 3600
        break
      case 'minutesBtn':
        totalSeconds = minutes.value * 60
        break
    }

    days.value = totalSeconds / 86400
    hours.value = totalSeconds / 3600
    minutes.value = totalSeconds / 60
    seconds.value = totalSeconds
  }
}
