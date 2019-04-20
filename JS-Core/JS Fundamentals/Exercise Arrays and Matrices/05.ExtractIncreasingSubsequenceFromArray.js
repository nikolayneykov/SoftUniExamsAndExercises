function extractSequence (params) {
  let sequence = [params.shift()]

  params.forEach(e => {
    if (e >= sequence[sequence.length - 1]) {
      sequence.push(e)
    }
  })

  console.log(sequence.join('\n'))
}

extractSequence([1, 3, 8, 4, 10, 12, 3, 2, 24])
