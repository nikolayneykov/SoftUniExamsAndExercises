class Organization {
  constructor (name, budget) {
    this.name = name
    this.employees = []
    this.budget = budget
    this._departmentsBudget = {
      marketing: this.budget * 0.4,
      finance: this.budget * 0.25,
      production: this.budget * 0.35
    }
  }

  get departmentsBudget () {
    return this._departmentsBudget
  }

  getEmployeeIndex (employeeName) {
    return this.employees.findIndex(e => e.employeeName === employeeName)
  }

  add (employeeName, department, salary) {
    if (this.departmentsBudget[department] < salary) {
      return `The salary that ${department} department ` +
        `can offer to you Mr./Mrs. ${employeeName} is ` +
        `$${this.departmentsBudget[department]}.`
    }

    this.employees.push({ employeeName, department, salary })
    this._departmentsBudget[department] -= salary

    return `Welcome to the ${department} team Mr./Mrs. ${employeeName}.`
  }

  employeeExists (employeeName) {
    let employeeIndex = this.getEmployeeIndex(employeeName)

    return employeeIndex === -1
      ? `Mr./Mrs. ${employeeName} is not working in ${this.name}.`
      : `Mr./Mrs. ${employeeName} is part of the ` +
      `${this.employees[employeeIndex].department} department.`
  }

  leaveOrganization (employeeName) {
    let employeeIndex = this.getEmployeeIndex(employeeName)

    if (employeeIndex === -1) {
      return `Mr./Mrs. ${employeeName} is not working in ${this.name}.`
    } else {
      this._departmentsBudget += this.employees[employeeIndex].salary
      this.employees.splice(employeeIndex, 1)
      return `It was pleasure for ${this.name} to work with Mr./Mrs. ${employeeName}.`
    }
  }

  status () {
    let sortedEmployees = this.employees.sort((a, b) => b.salary - a.salary)

    let marketingEmployees = sortedEmployees
      .filter(e => e.department === 'marketing')
      .map(e => e.employeeName)

    let financeEmployees = sortedEmployees
      .filter(e => e.department === 'finance')
      .map(e => e.employeeName)

    let productionEmployees = sortedEmployees
      .filter(e => e.department === 'production')
      .map(e => e.employeeName)

    let info = `${this.name.toUpperCase()} DEPARTMENTS:` +
      `\nMarketing | Employees: ${marketingEmployees.length}: ` +
      `${marketingEmployees.join(', ')} | ` +
      `Remaining Budget: ${this.departmentsBudget['marketing']}` +
      `\nFinance | Employees: ${financeEmployees.length}: ` +
      `${financeEmployees.join(', ')} | ` +
      `Remaining Budget: ${this.departmentsBudget['finance']}` +
      `\nProduction | Employees: ${productionEmployees.length}: ` +
      `${productionEmployees.join(', ')} | ` +
      `Remaining Budget: ${this.departmentsBudget['production']}`

    return info
  }
}
