function solve() {
   
   let robots = {
      softuni: document.querySelector('#softuni'),
      google: document.querySelector('#google'),
      facebook: document.querySelector('#facebook')
   }

   robots.softuni.distance =0;
   robots.google.distance = 0;
   robots.facebook.distance =0;

   let [robotName, moveInput] = document.querySelectorAll('input[type="text"]');


   document.querySelector('button').addEventListener('click', move);

   let message = document.querySelector('span');
   let finishedCount = 1;

   function move() {
      let name = robotName.value.toLowerCase();
      let [direction, distance] = moveInput.value.split(' ');
      direction = direction.toLowerCase();
      distance = Number(distance);


      if (name && direction && distance && robots.hasOwnProperty(name)) {
         let currentRobot = robots[name];

         if (direction === 'forward') {
            if (currentRobot.distance + distance <= 80) {
               currentRobot.distance += distance;

               if (currentRobot.distance === 80) {
                  switch (finishedCount) {
                     case 1: message.textContent = `${name.toUpperCase()} WIN THE RACE!`; break;
                     case 2: message.textContent = `${name.toUpperCase()} FINISHED 2`; break;
                     case 3: message.textContent = `${name.toUpperCase()} FINISHED 3`; break;
                  }
                  finishedCount++;
               } else {
                  message.textContent = `${name} move ${distance} forward`;
               }
            } else {
               message.textContent = `${name} cant move so forward`;
            }
         } else if (direction === 'backward' && (currentRobot.distance === 80 || currentRobot.distance - distance < 0)) {
            message.textContent = `${name} can't move so backward`;
         }

         currentRobot.style.marginLeft = `${currentRobot.distance}%`;
         robotName.value = '';
         moveInput.value = '';
      }
   }
}

//THIS EXERCSISE HAS FUCKED UP UNIT TESTS!!!
