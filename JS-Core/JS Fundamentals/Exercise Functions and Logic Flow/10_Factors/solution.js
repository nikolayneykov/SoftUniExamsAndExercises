function solve() {
   let num = +document.querySelector('#num').value;
   let arr = [];

   for (let i = 1; i <= num; i++) {
      if (num % i === 0) {
         arr.push(i);
      }
   }
   
   document.querySelector('#result').textContent = arr.join(' ');
}