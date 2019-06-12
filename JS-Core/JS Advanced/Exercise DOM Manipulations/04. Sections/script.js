function create (words) {
  let content = document.querySelector('#content')

  words.forEach(w => {
    let div = document.createElement('div')
    let p = document.createElement('p')
    p.style.display = 'none'
    p.textContent = w
    div.appendChild(p)
    div.addEventListener(
      'click',
      ev => (ev.target.querySelector('p').style.display = 'block')
    )
    content.appendChild(div)
  })
}
