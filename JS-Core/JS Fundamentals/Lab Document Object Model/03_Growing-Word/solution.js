function solve() {
   let clicks = 0;

   document.querySelector('button').addEventListener('click', function () {
      let p = document.querySelector('div#exercise p');
      let color = '';

      if (clicks % 3 === 0) {
         color = 'blue';
      } else if (clicks % 3 === 1) {
         color = 'green';
      } else if (clicks % 3 === 2) {
         color = 'red';
      }

      clicks++;
      
      p.style.color = color;
      p.style.fontSize = `${clicks * 2}px`;
   });
}