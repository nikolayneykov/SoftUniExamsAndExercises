function solve (ticketDescriptions, sortingCriteria) {
  class Ticket {
    constructor (destination, price, status) {
      this.destination = destination
      this.price = price
      this.status = status
    }

    compareTo (otherTicket, sortingCriteria) {
      return this[sortingCriteria] > otherTicket[sortingCriteria]
    }
  }

  let tickets = ticketDescriptions
    .map(x => {
      let [destination, price, status] = x.split('|')
      return new Ticket(destination, +price, status)
    })
    .sort((a, b) => a.compareTo(b, sortingCriteria))

  return tickets
}

console.log(
  solve(
    [
      'Philadelphia|94.20|available',
      'New York City|95.99|available',
      'New York City|95.99|sold',
      'Boston|126.20|departed'
    ],
    'destination'
  )
)
