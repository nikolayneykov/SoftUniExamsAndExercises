function solve () {
  let input = document.querySelector('#input')
  let output = document.querySelector('#output p')
  let [filterBtn, sortBtn, rotateBtn, getBtn] = document.querySelectorAll(
    'button'
  )
  filterBtn.addEventListener('click', filter)
  sortBtn.addEventListener('click', sort)
  rotateBtn.addEventListener('click', rotate)
  getBtn.addEventListener('click', get)

  function filter () {
    let text = input.value
    let criteria = document.querySelector('#filterSecondaryCmd').value
    let pos = document.querySelector('#filterPosition').value - 1

    if (criteria === 'uppercase') {
      output.textContent += text.match(/[A-Z]/g)[pos]
    } else if (criteria === 'lowercase') {
      output.textContent += text.match(/[a-z]/g)[pos]
    } else if (criteria === 'nums') {
      output.textContent += text.match(/\d/g)[pos]
    }
  }

  function sort () {
    let text = input.value.split('')
    let criteria = document.querySelector('#sortSecondaryCmd').value
    let pos = document.querySelector('#sortPosition').value - 1

    if (criteria === 'A') {
      output.textContent += text.sort((a, b) => a.localeCompare(b))[pos]
    } else if (criteria === 'Z') {
      output.textContent += text.sort((a, b) => b.localeCompare(a))[pos]
    }
  }

  function rotate () {
    let text = input.value.split('')
    let rotations = +document.querySelector('#rotateSecondaryCmd').value
    let pos = document.querySelector('#rotatePosition').value - 1

    while (rotations > 0) {
      text.unshift(text.pop())
      rotations--
    }

    output.textContent += text[pos]
  }

  function get () {
    let pos = document.querySelector('#getPosition').value - 1
    output.textContent += input.value[pos]
  }
}
