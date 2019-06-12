function addItem () {
  let input = document.querySelector('#newItemText').value
  let item = document.createElement('li')
  item.textContent = input
  document.querySelector('#items').appendChild(item)
}
