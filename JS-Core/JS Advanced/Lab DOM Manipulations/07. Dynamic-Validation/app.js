function validate () {
  const regex = /^[a-z]+@[a-z]+\.[a-z]+$/

  document.querySelector('#email').addEventListener('change', ev => {
    let target = ev.target

    if (!regex.test(target.value)) {
      target.className = 'error'
    } else {
      target.removeAttribute('class')
    }
  })
}
