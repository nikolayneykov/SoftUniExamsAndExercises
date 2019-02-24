function calculateTicketPrice(dayType, age) {
    let ticketPrice = '';
    if (age >= 0 && age <= 18) {
        if (dayType === 'Weekday') {
            ticketPrice = '12$';
        } else if (dayType === 'Weekend') {
            ticketPrice = '15$';
        } else if (dayType === 'Holiday') {
            ticketPrice = '5$';
        }
    } else if (age > 18 && age <= 64) {
        if (dayType === 'Weekday') {
            ticketPrice = '18$';
        } else if (dayType === 'Weekend') {
            ticketPrice = '20$';
        } else if (dayType === 'Holiday') {
            ticketPrice = '12$';
        }
    } else if (age > 64 && age <= 122) {
        if (dayType === 'Weekday') {
            ticketPrice = '12$';
        } else if (dayType === 'Weekend') {
            ticketPrice = '15$';
        } else if (dayType === 'Holiday') {
            ticketPrice = '10$';
        }
    } else {
        ticketPrice = 'Error!';
    }
    console.log(ticketPrice);
}

calculateTicketPrice('Weekday',18);
calculateTicketPrice('Weekend', 32);
calculateTicketPrice('Holiday',70);
calculateTicketPrice('Weekend',-1);
calculateTicketPrice('Weekend',200);