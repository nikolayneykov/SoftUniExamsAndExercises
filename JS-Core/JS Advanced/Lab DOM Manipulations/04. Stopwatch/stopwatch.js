function stopwatch () {
  let start = document.querySelector('#startBtn')
  start.addEventListener('click', changeTimer)

  let stop = document.querySelector('#stopBtn')
  stop.addEventListener('click', changeTimer)

  let time = document.querySelector('#time')
  let count = 1
  let interval = null

  function changeTimer (ev) {
    let target = ev.target

    if (target.id === 'startBtn') {
      time.textContent = `00:00`
      start.disabled = true
      stop.disabled = false
      interval = setInterval(() => {
        let minutes = Math.floor(count / 60)
          .toString()
          .padStart(2, '0')
        let seconds = (count % 60).toString().padStart(2, '0')

        time.textContent = `${minutes}:${seconds}`
        count++
      }, 1000)
    } else {
      start.disabled = false
      stop.disabled = true
      clearInterval(interval)
    }
  }
}
