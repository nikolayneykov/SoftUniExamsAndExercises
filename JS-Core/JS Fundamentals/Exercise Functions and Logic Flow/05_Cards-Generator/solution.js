function solve() {
    const indexes = {
        '2': 2, '3': 3, '4': 4, '5': 5,
        '6': 6, '7': 7, '8': 8, '9': 9,
        '10': 10, 'J': 11, 'Q': 12, 'K': 13, 'A': 14
    };

    const values = {
        '2': 2, '3': 3, '4': 4, '5': 5,
        '6': 6, '7': 7, '8': 8, '9': 9,
        '10': 10, '11': 'J', '12': 'Q', '13': 'K', '14': 'A'
    };

    let inputFrom = document.querySelector('#from');
    let inputTo = document.querySelector('#to');
    let selectSuit = document.querySelector('select');
    let cards = document.querySelector('#cards');
    document.querySelector('button').addEventListener('click', displayCards);

    function displayCards() {
        let suit = selectSuit.value.split(' ')[1];
        let startIndex = indexes[inputFrom.value];
        let endIndex = indexes[inputTo.value];

        for (let i = startIndex; i <= endIndex; i++) {
            let suitUp = document.createElement('p');
            suitUp.textContent = suit;
            let suitDown = document.createElement('p');
            suitDown.textContent = suit;
            let value = document.createElement('p');
            value.textContent = values[i];

            let card = document.createElement('div');
            card.setAttribute('class', 'card');
            card.appendChild(suitUp);
            card.appendChild(value);
            card.appendChild(suitDown);

            cards.appendChild(card);
        }
    }
}