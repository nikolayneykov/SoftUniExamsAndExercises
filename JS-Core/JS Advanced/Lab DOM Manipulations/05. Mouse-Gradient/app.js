function attachGradientEvents () {
  let result = document.querySelector('#result')
  let gradient = document.querySelector('#gradient')

  gradient.addEventListener('mousemove', ev => {
    let percent = ~~((ev.offsetX / ev.target.clientWidth) * 100)
    result.textContent = `${percent}%`
  })

  gradient.addEventListener('mouseout', () => {
    result.textContent = ''
  })
}
