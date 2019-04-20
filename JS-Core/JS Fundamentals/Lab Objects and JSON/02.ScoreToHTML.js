function solve (params) {
  let escapeHtml = str => {
    return str
      .replace(/&/g, '&amp;')
      .replace(/</g, '&lt;')
      .replace(/>/g, '&gt;')
      .replace(/"/g, '&quot;')
      .replace(/'/g, '&#39;')
  }

  let arr = JSON.parse(params)

  let html = '<table>\n  <tr>'
  Object.keys(arr[0]).forEach(key => (html += `<th>${escapeHtml(key)}</th>`))
  html += '</tr>\n'

  arr.forEach(obj => {
    html += '  <tr>'
    Object.values(obj).forEach(
      value => (html += `<td>${escapeHtml(value.toString())}</td>`)
    )
    html += '</tr>\n'
  })
  html += '</table>'

  console.log(html)
}

solve(
  '[{"name":"Pesho & Kiro","score":479},{"name":"Gosho, Maria & Viki","score":205}]'
)
