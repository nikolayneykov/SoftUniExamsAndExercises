function solve() {
   Array.from(document.querySelectorAll('button'))
      .forEach(b => b.addEventListener('click', toggleInfo));

   Array.from(document.querySelectorAll('input[value="lock"]'))
      .forEach(i=>i.addEventListener('change',lockInfo));

   function toggleInfo() {
      let elements = this.parentNode.children;
      let isLocked = elements[2].checked;
      let hiddenInfo = elements[9];
      let button = elements[10];

      if (!isLocked && button.textContent === 'Show more') {
         hiddenInfo.style.display = 'block';
         button.textContent = 'Hide it';
      } else if (!isLocked && button.textContent === 'Hide it') {
         hiddenInfo.style.display = 'none';
         button.textContent = 'Show more';
      }
   }

   function lockInfo() {
      let elements = this.parentNode.children;    
      let hiddenInfo = elements[9];
      let button = elements[10];

      hiddenInfo.style.display = 'none';
      button.textContent = 'Show more';
   }
} 