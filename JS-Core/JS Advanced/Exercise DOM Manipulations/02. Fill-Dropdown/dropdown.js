function addItem () {
  let menu = document.querySelector('#menu')
  let optionText = document.querySelector('#newItemText')
  let optionValue = document.querySelector('#newItemValue')

  let option = document.createElement('option')
  option.text = optionText.value
  option.value = optionValue.value

  menu.appendChild(option)
  optionText.value = ''
  optionValue.value = ''
}
