function humanizeNumbers(text) {
    let result = text.match(/\d+/g);

    for (let number of result) {
        if (number === '1') {
            number += 'st';
        } else if (number.endsWith('2') && number !== '12') {
            number += 'nd';
        } else if (number.endsWith('3') && number !== '13') {
            number += 'rd';
        } else {
            number += 'th';
        }

        console.log(number);
    }
}

humanizeNumbers('The school has 256 students. In each class there are 26 chairs, 13 desks and 1 board.');