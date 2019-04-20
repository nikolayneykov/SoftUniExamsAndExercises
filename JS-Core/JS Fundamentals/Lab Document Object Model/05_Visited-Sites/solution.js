function solve() {
  let divs = document.querySelectorAll('#exercise div');

  for (let div of divs) {
    let a = div.querySelector('a');
    let span = div.querySelector('span');
    let count = Number(span.textContent.split(' ')[1]);
    a.addEventListener('click', function () {
      count++
      span.textContent = `Visited: ${count} times`;
    });
  } 
}