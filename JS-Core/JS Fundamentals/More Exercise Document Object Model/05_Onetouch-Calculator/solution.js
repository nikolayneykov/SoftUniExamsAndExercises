function solve() {
   let operands = [...document.querySelectorAll('.numbers')];
   let operators = [...document.querySelectorAll('.operators')];
   let expressionPattern = /^(\d+)([+\-*/])(\d+)$/;
   let resultParagraph = document.querySelector('#result');
   attachEvents();

   function attachEvents() {
      operands.forEach(n => n.addEventListener('mouseover', displayItem));

      operators.forEach(o => {
         if (o.id === 'equalSign') {
            o.addEventListener('click', calculate);
         } else {
            o.addEventListener('click', displayItem);
         }
      });
   }

   function removeEvents() {
      operands.forEach(n => n.removeEventListener('mouseover', displayItem));

      operators.forEach(o => {
         if (o.id === 'equalSign') {
            o.removeEventListener('click', calculate);
         } else {
            o.removeEventListener('click', displayItem);
         }
      });
   }

   function displayItem() {
      result.textContent += this.textContent;
   }

   function calculate() {
      let match = result.textContent.match(expressionPattern);
      if (match) {
         let leftOperand = +match[1];
         let operator = match[2];
         let rightOperand = +match[3];

         let result = 0;
         switch (operator) {
            case '+': result = leftOperand + rightOperand; break;
            case '-': result = leftOperand - rightOperand; break;
            case '*': result = leftOperand * rightOperand; break;
            case '/': result = leftOperand / rightOperand; break;
         }
         resultParagraph.textContent = result;

         removeEvents();
         setTimeout(() => {
            attachEvents();
            resultParagraph.textContent = '';
         }, 5000);
      } else {
         resultParagraph.textContent = 'Invalid Expression!';
         setTimeout(() => {
            resultParagraph.textContent = '';
         }, 2000);
      }
   }

}