function solve () {
  class Employee {
    constructor (name, age) {
      if (new.target === Employee) {
        throw new TypeError('Cannot instantiate abstract class Employee.')
      }

      this.name = name
      this.age = age
      this.salary = 0
      this.tasks = []
    }

    work () {
      let task = this.tasks.shift()
      console.log(`${this.name} ${task}`)
      this.tasks.push(task)
    }

    collectSalary () {
      console.log(`${this.name} received ${this.getSalary()} this month.`)
    }

    getSalary () {
      return this.salary
    }
  }

  class Junior extends Employee {
    constructor (name, age) {
      super(name, age)
      this.tasks.push('is working on a simple task.')
    }
  }

  class Senior extends Employee {
    constructor (name, age) {
      super(name, age)
      this.tasks.push(
        ...[
          'is working on a complicated task.',
          'is taking time off work.',
          'is supervising junior workers.'
        ]
      )
    }
  }

  class Manager extends Employee {
    constructor (name, age) {
      super(name, age)
      this.tasks.push(
        ...['scheduled a meeting.', 'is preparing a quarterly report.']
      )
      this.dividend = 0
    }

    getSalary () {
      return this.salary + this.dividend
    }
  }

  return { Employee, Junior, Senior, Manager }
}
