function solve () {
  let str1 = document.querySelector('#str1').value
  let str2 = document.querySelector('#str2').value

  let result = 'Error!'
  str1 = str1
    .split(' ')
    .map(x => x[0].toUpperCase() + x.slice(1).toLowerCase())
    .join('')

  if (str2 === 'Pascal Case') {
    result = str1
  } else if (str2 === 'Camel Case') {
    result = str1[0].toLowerCase() + str1.slice(1)
  }

  document.querySelector('#result').textContent = result
}
