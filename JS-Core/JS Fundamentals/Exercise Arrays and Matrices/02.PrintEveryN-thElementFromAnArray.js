function printNthElement (params) {
  let [step, arr] = [+params.pop(), params]
  arr.forEach((e, i) => {
    if (i % step === 0) {
      console.log(e)
    }
  })
}

printNthElement(['5', '20', '31', '4', '20', '2'])
