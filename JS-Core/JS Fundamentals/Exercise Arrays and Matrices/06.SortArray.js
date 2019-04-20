function sortArr (arr) {
  arr
    .sort((a, b) => a.length - b.length || a.localeCompare(b))
    .forEach(x => console.log(x))
}

sortArr(['alpha', 'beta', 'gamma'])
