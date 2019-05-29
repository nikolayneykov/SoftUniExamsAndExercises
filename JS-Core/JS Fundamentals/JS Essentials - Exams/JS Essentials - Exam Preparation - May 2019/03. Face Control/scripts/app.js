function getData () {
  let input = JSON.parse(document.querySelector('textarea').value)
  let paragraphs = {
    peopleIn: document.querySelector('#peopleIn p'),
    peopleOut: document.querySelector('#peopleOut p'),
    blacklist: document.querySelector('#blacklist p')
  }

  let lastElement = input.pop()

  let disco = (function () {
    let lists = {
      peopleIn: [],
      peopleOut: [],
      blacklist: []
    }

    function peopleIn (person) {
      let personBlacklist = lists.blacklist.find(
        p => p.firstName === person.firstName && p.lastName === person.lastName
      )

      if (!personBlacklist) {
        lists.peopleIn.push(person)
        displayLists()
      }
    }

    function peopleOut (person) {
      let personIn = lists.peopleIn.find(
        p => p.firstName === person.firstName && p.lastName === person.lastName
      )

      if (personIn) {
        let index = lists.peopleIn.indexOf(personIn)
        lists.peopleIn.splice(index, 1)
        lists.peopleOut.push(person)
        displayLists()
      }
    }

    function blacklist (person) {
      let personIn = lists.peopleIn.find(
        p => p.firstName === person.firstName && p.lastName === person.lastName
      )

      if (personIn) {
        let index = lists.peopleIn.indexOf(personIn)
        lists.peopleIn.splice(index, 1)
        lists.peopleOut.push(person)
      }
      lists.blacklist.push(person)
      displayLists()
    }

    function displayLists () {
      paragraphs.peopleIn.textContent = lists.peopleIn
        .map(x => JSON.stringify(x))
        .join(' ')
      paragraphs.peopleOut.textContent = lists.peopleOut
        .map(x => JSON.stringify(x))
        .join(' ')
      paragraphs.blacklist.textContent = lists.blacklist
        .map(x => JSON.stringify(x))
        .join(' ')

      if (lastElement.action !== '' && lastElement.criteria !== '') {
        paragraphs[lastElement.action].textContent = lists[lastElement.action]
          .sort((a, b) =>
            a[lastElement.criteria].localeCompare(b[lastElement.criteria])
          )
          .map(x => JSON.stringify(x))
          .join(' ')
      }
    }

    return { peopleIn, peopleOut, blacklist }
  })()

  input.forEach(p =>
    disco[p.action]({ firstName: p.firstName, lastName: p.lastName })
  )
}
