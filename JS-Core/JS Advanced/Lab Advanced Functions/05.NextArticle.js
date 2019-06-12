function getArticleGenerator (articles) {
  let content = document.querySelector('#content')
  let id = 0

  return () => {
    if (articles[id]) {
      let article = document.createElement('article')
      article.textContent = articles[id]
      content.appendChild(article)
      id++
    }
  }
}
