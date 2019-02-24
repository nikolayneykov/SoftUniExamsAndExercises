function printDayofWeek(num) {
    let days = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday', 'Sunday'];
    let day = '';
    if (num >= 1 && num <= 7) {
        day = days[num-1];
    }else{
        day = 'Invalid day!';
    }
    console.log(day);
}
printDayofWeek(4);
printDayofWeek(10);