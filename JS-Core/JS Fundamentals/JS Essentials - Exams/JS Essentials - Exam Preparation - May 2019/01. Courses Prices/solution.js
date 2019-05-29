function solve (fundamentals, advanced, applications, educationForm) {
  let [totalPrice, fundPrice, advancedPrice, appsPrice] = [0, 170, 180, 190]

  if (fundamentals && advanced) {
    advancedPrice *= 0.9
  }

  if (fundamentals && advanced && applications) {
    totalPrice = (fundPrice + advancedPrice + appsPrice) * 0.94
  } else {
    totalPrice += fundamentals ? fundPrice : 0
    totalPrice += advanced ? advancedPrice : 0
    totalPrice += applications ? appsPrice : 0
  }

  if (educationForm === 'online') {
    totalPrice *= 0.94
  }

  console.log(Math.round(totalPrice))
}

solve(true, false, false, 'onsite')
