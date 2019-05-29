function solve () {
  Array.from(document.querySelectorAll('.seat')).forEach(s =>
    s.addEventListener('click', takeSeat)
  )

  document
    .querySelector('#summary button')
    .addEventListener('click', printSummary)

  let zones = Array.from(document.querySelectorAll('section'))
  let sectors = ['A', 'B', 'C']
  let output = document.querySelector('#output')
  let [fans, profit] = [0, 0]

  let prices = {
    levski: [10, 7, 5],
    litex: [10, 7, 5],
    vip: [25, 15, 10]
  }

  function takeSeat () {
    let seat = this.textContent
    let zone = zones.find(x =>
      [...x.querySelectorAll('.seat')].some(s => s === this)
    ).className
    let sector = sectors[this.parentNode.cellIndex]
    if (this.isTaken) {
      output.value += ` Seat ${seat} in zone ${zone} sector ${sector} is unavailable.\n`
    } else {
      output.value += ` Seat ${seat} in zone ${zone} sector ${sector} was taken.\n`
      this.style.background = 'rgba(255, 0, 0)'
      this.isTaken = true
      fans++
      profit += prices[zone.toLowerCase()][this.parentNode.cellIndex]
    }
  }

  function printSummary () {
    this.nextElementSibling.textContent = `${profit} leva, ${fans} fans.`
  }
}
