function deleteByEmail () {
  let input = document.querySelector('input').value
  let result = document.querySelector('#result')
  let emails = [...document.querySelectorAll('td:nth-child(2)')]
  let email = emails.find(td => td.textContent === input)

  if (email) {
    email.parentNode.remove()
    result.textContent = 'Deleted.'
  } else {
    result.textContent = 'Not found.'
  }
}
