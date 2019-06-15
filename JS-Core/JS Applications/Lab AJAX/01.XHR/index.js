function loadRepos () {
  let url = 'https://api.github.com/users/testnakov/repos'
  let req = new XMLHttpRequest()

  req.onreadystatechange = (ev) => {
    let target = ev.target
    if (target.readyState === 4 && target.status === 200) {
      document.querySelector('#res').textContent = target.responseText
    }
  }

  req.open('GET', url)
  req.send()
}
