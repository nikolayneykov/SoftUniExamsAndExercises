function solve (table, param) {
  let [command, header, value] = param.split(' ')
  let index = table[0].indexOf(header)

  if (command === 'hide') {
    table.map(x => x.splice(index, 1))
  } else if (command === 'sort') {
    table = table
      .splice(0, 1)
      .concat(table.sort((a, b) => a[index].localeCompare(b[index])))
  } else if (command === 'filter') {
    table = table.splice(0, 1).concat(table.filter(x => x[index] === value))
  }

  table.forEach(row => console.log(row.join(' | ')))
}

solve(
  [
    ['firstName', 'age', 'grade', 'course'],
    ['Peter', '25', '5.00', 'JS-Core'],
    ['George', '34', '6.00', 'Tech'],
    ['Marry', '28', '5.49', 'Ruby']
  ],
  'filter firstName Marry'
)
