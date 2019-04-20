function solve () {
  let arr = JSON.parse(document.querySelector('#arr').value)
  let result = document.querySelector('#result')
  let shelves = []

  arr.forEach(line => {
    if (line.includes(' -> ')) {
      let [id, genre] = line.split(' -> ')
      let currentShelf = shelves.find(s => s.id === id)

      if (!currentShelf) {
        shelves.push({ id, genre, books: [] })
      }
    } else if (line.includes(': ') && line.includes(', ')) {
      let [title, author, genre] = line.split(/: |, /)
      let currentShelf = shelves.find(s => s.genre === genre)

      if (currentShelf) {
        currentShelf.books.push({ title, author })
      }
    }
  })

  shelves
    .sort((a, b) => b.books.length - a.books.length)
    .forEach(shelf => {
      let shelfParagraph = document.createElement('p')
      shelfParagraph.textContent = `${shelf.id} ${shelf.genre}: ${shelf.books.length}`
      result.appendChild(shelfParagraph)

      shelf.books
        .sort((a, b) => a.title.localeCompare(b.title))
        .forEach(book => {
          let bookParagraph = document.createElement('p')
          bookParagraph.textContent = `--> ${book.title}: ${book.author}`
          result.appendChild(bookParagraph)
        })
    })
}
