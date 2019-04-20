function solve() {
   let steps = Array.from(document.querySelectorAll('div[id$="Step"]'));
   let stepCounter = 0;
   let [next, cancel] = document.querySelectorAll('button');
   cancel.addEventListener('click', hideAll);
   next.addEventListener('click', showNext);

   function showNext() {
      switch (stepCounter) {
         case 0:
            document.querySelector('#content').style.background = 'none';
            steps[0].style.display = 'block';
            stepCounter++;
            break;
         case 1:
            let isAgreeChecked = document.querySelector('input[value="agree"]').checked;

            if (isAgreeChecked) {
               steps[0].style.display = 'none';
               steps[1].style.display = 'block';
               next.style.display = 'none';

               setTimeout(() => {
                  next.style.display = 'inline';
               }, 3000);

               stepCounter++;
            }
            break;
         case 2:
            steps[1].style.display = 'none';
            steps[2].style.display = 'block';
            next.style.display = 'none';
            cancel.textContent = 'Finish';
            break;
      }
   }

   function hideAll() {
      document.querySelector('section').style.display = 'none';
   }
}