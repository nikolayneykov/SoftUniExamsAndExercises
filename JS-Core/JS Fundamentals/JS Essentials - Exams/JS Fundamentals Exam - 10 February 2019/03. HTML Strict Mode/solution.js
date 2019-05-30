function solve (arr) {
  console.log(
    arr
      .filter(x => /^<(\w+)>(.+)<(\/\1)>$/.test(x))
      .map(x => x.replace(/<\/*\w+>/gi, ''))
      .join(' ')
  )
}

solve([
  '<div><p>This</p> is</div>',
  '<div><a>perfectly</a></div>',
  '<divs><p>valid</p></divs>',
  '<div><p>This</div></p>',
  '<div><p>is not</p><div>'
])
