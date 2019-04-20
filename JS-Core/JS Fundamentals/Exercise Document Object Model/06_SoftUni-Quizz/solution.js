function solve() {
    const rightAnswers = ['2013', 'Pesho', 'Nakov'];
    let rightAnswersCount = 0;
    let result = document.querySelector('#result');
    let buttons = Array.from(document.querySelectorAll('button'));
    buttons.forEach(b => b.addEventListener('click', showNext));

    function showNext() {
        let sectionElements = Array.from(this.parentNode.children);
        let checkedAnswer = sectionElements.find(e => e.checked);
        this.parentNode.style.display = 'block';

        if (checkedAnswer) {
            if (rightAnswers.includes(checkedAnswer.value)) {
                rightAnswersCount++;
            }

            let index = buttons.indexOf(this);
            if (index < 2) {
                let nextSection = buttons[index + 1].parentNode;
                nextSection.style.display = 'block';
            } else {
                result.textContent = rightAnswersCount === 3
                    ? 'You are recognized as top SoftUni fan!'
                    : `You have ${rightAnswersCount} right answers`;
            }

            this.removeEventListener('click', showNext);
        }
    }
}