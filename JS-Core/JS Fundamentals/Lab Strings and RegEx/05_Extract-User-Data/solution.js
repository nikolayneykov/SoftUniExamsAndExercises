function solve () {
  let arr = JSON.parse(document.querySelector('#arr').value)
  let result = document.querySelector('#result')

  let regex = /^([A-Z][a-z]*\s[A-Z][a-z]*)\s(\+359(\s|-)\d\3\d{3}\3\d{3})\s([a-z\d]+@[a-z]+\.[a-z]{2,3})$/

  arr.forEach(data => {
    let match = data.match(regex)

    if (match) {
      let [name, phone, email] = [match[1], match[2], match[4]]
      let pName = document.createElement('p')
      let pPhone = document.createElement('p')
      let pEmail = document.createElement('p')

      pName.textContent = `Name: ${name}`
      pPhone.textContent = `Phone Number: ${phone}`
      pEmail.textContent = `Email: ${email}`

      result.appendChild(pName)
      result.appendChild(pPhone)
      result.appendChild(pEmail)
    } else {
      let pInvalid = document.createElement('p')
      pInvalid.textContent = 'Invalid data'
      result.appendChild(pInvalid)
    }

    let pSeparator = document.createElement('p')
    pSeparator.textContent = '- - -'
    result.appendChild(pSeparator)
  })
}
