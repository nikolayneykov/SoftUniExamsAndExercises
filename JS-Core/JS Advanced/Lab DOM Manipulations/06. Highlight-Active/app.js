function focus () {
  Array.from(document.querySelectorAll('input')).forEach(e => {
    e.addEventListener('focus', event => {
      event.target.parentNode.className = 'focused'
    })
    e.addEventListener('blur', event => {
      event.target.parentNode.removeAttribute('class')
    })
  })
}
