function createPersonObject(firstName, lastName, age) {
    let person = {
        firstName, lastName, age,
    };
    
    for(let key in person){
        console.log(`${key}: ${person[key]}`);
    }
}
createPersonObject("Peter", "Pan", "20");