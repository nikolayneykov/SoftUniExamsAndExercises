function findDates(sentences) {
    let regex = new RegExp(/\b(\d{1,2}\-[A-Z][a-z]{2}\-\d{4})\b/, 'g');
    let validDates = [];
    for (let sentence of sentences) {
        let date = '';
        while (date = regex.exec(sentence)) {
            date = date[0].replace('-', ' ').replace('-', ' ');
            validDates.push(date);
        }
    }
    validDates.forEach(x => console.log(x));
}
findDates(['I am born on 28-Feb-1994.', 'This is not date: 512-Jan-1996.', 'My father is born on the 29-Jul-1955.']);


//: 12-Jun-1999