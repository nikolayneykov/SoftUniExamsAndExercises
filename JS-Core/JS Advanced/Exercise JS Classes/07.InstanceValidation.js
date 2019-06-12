class CheckingAccount {
  constructor (clientId, email, firstName, lastName) {
    this.clientId = clientId
    this.email = email
    this.firstName = firstName
    this.lastName = lastName
  }

  set clientId (value) {
    if (!/^\d{6}$/.test(value)) {
      throw new TypeError('Client ID must be a 6-digit number')
    }
  }

  set email (value) {
    if (!/^\w+@[A-Za-z.]+$/.test(value)) {
      throw new TypeError('Invalid e-mail')
    }
  }

  set firstName (value) {
    if (!/^.{3,20}$/.test(value)) {
      throw new TypeError('First name must be between 3 and 20 characters long')
    } else if (!/^[A-Za-z]{3,20}$/.test(value)) {
      throw new TypeError('First name must contain only Latin characters')
    }
  }

  set lastName (value) {
    if (!/^.{3,20}$/.test(value)) {
      throw new TypeError('Last name must be between 3 and 20 characters long')
    } else if (!/^[A-Za-z]{3,20}$/.test(value)) {
      throw new TypeError('Last name must contain only Latin characters')
    }
  }
}
