function printPrice(day, service, hour) {
    let price = 0;

    if (service === 'Fitness') {
        if (hour >= 8 && hour <= 15) {
            if (day !== 'Saturday' && day !== 'Sunday') {
                price = 5;
            } else {
                price = 8;
            }
        } else {
            if (day !== 'Saturday' && day !== 'Sunday') {
                price = 7.5;
            } else {
                price = 8;
            }
        }
    } else if (service === 'Sauna') {
        if (hour >= 8 && hour <= 15) {
            if (day !== 'Saturday' && day !== 'Sunday') {
                price = 4;
            } else {
                price = 7;
            }
        } else {
            if (day !== 'Saturday' && day !== 'Sunday') {
                price = 6.5;
            } else {
                price = 7;
            }
        }
    } else if (service === 'Instructor') {
        if (hour >= 8 && hour <= 15) {
            if (day !== 'Saturday' && day !== 'Sunday') {
                price = 10;
            } else {
                price = 15;
            }
        } else {
            if (day !== 'Saturday' && day !== 'Sunday') {
                price = 12.5;
            } else {
                price = 15;
            }
        }
    }

    console.log(price);
}

printPrice('Monday', 'Sauna', 15.30);
