class Vacation {
  constructor (organizer, destination, budget) {
    this.organizer = organizer
    this.destination = destination
    this.budget = budget
    this.kids = {}
  }

  registerChild (name, grade, budget) {
    if (budget < this.budget) {
      return `${name}'s money is not enough ` +
        `to go on vacation to ${this.destination}.`
    } else if (!this.kids.hasOwnProperty(grade)) {
      this.kids[grade] = []
    }

    if (this.kids[grade].findIndex(k => k.startsWith(name)) !== -1) {
      return `${name} is already in the list ` +
        `for this ${this.destination} vacation.`
    }

    this.kids[grade].push(`${name}-${budget}`)

    return this.kids[grade]
  }

  removeChild (name, grade) {
    if (!this.kids.hasOwnProperty(grade) ||
      !this.kids[grade].find(k => k.startsWith(name))) {
      return `We couldn't find ${name} in ${grade} grade.`
    }

    let kidIndex = this.kids[grade].findIndex(k => k.startsWith(name))
    this.kids[grade].splice(kidIndex, 1)

    return this.kids[grade]
  }

  toString () {
    return this.numberOfChildren === 0
      ? 'No children are enrolled for the trip ' +
      `and the organization of ${this.organizer} falls out...`
      : `${this.organizer} will take ` +
      `${this.numberOfChildren} children on trip to ${this.destination}\n` +
      Object.entries(this.kids)
        .map(([grade, kids]) => {
          return `Grade: ${grade}\n` +
            kids.map((kid, index) => `${index + 1}. ${kid}`).join('\n')
        })
        .join('\n') + '\n'
  }

  get numberOfChildren () {
    return Object.values(this.kids)
      .map(x => x.length)
      .reduce((acc, el) => acc + el, 0)
  }
}