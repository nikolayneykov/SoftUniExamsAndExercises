function solve() {
    let myChatBox = document.querySelector('#myChatBox');
    let peshoChatBox = document.querySelector('#peshoChatBox');
    let chatChronology = document.querySelector('#chatChronology');
    Array.from(document.querySelectorAll('button')).forEach(b => b.addEventListener('click', sendMessage));

    function sendMessage() {
        let message = document.createElement('div');
        let span = document.createElement('span');
        let p = document.createElement('p');

        if (this.name === 'myBtn') {
            message.style.textAlign = 'left';
            span.textContent = 'Me';
            p.textContent = myChatBox.value;
            myChatBox.value = '';
        } else if (this.name === 'peshoBtn') {
            message.style.textAlign = 'right';
            span.textContent = 'Pesho';
            p.textContent = peshoChatBox.value;
            peshoChatBox.value = '';
        }

        message.appendChild(span);
        message.appendChild(p);
        chatChronology.appendChild(message);
    }
}