function convertToJson(name, lastName, hairColor) {
    let person = {
        name, lastName, hairColor
    };
    
    let personAsJson = JSON.stringify(person);
    console.log(personAsJson);
}
convertToJson('George',
    'Jones',
    'Brown'
);