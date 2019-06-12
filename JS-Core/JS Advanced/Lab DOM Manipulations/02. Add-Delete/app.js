function addItem () {
  let input = document.querySelector('#newText').value
  let item = document.createElement('li')
  item.textContent = input

  let deleteLink = document.createElement('a')
  deleteLink.href = '#'
  deleteLink.textContent = '[Delete]'
  deleteLink.addEventListener('click', ev => {
    ev.target.parentNode.remove()
  })

  item.appendChild(deleteLink)
  document.querySelector('#items').appendChild(item)
}
