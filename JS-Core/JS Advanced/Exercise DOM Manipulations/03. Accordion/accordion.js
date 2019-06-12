function toggle () {
  let divExtra = document.querySelector('#extra')
  let button = document.querySelector('.button')

  if (divExtra.style.display === 'none') {
    divExtra.style.display = 'block'
    button.textContent = 'Less'
  } else {
    divExtra.style.display = 'none'
    button.textContent = 'More'
  }
}
