function solve ([params]) {
  let words = {}

  params
    .toLowerCase()
    .match(/\w+/g)
    .forEach(word => {
      if (!words.hasOwnProperty(word)) {
        words[word] = 0
      }

      words[word]++
    })

  Object.entries(words)
    .sort((a, b) => a[0].localeCompare(b[0]))
    .forEach(([word, count]) => {
      console.log(`'${word}' -> ${count} times`)
    })
}

solve(["Far too slow, you're far too slow."])
