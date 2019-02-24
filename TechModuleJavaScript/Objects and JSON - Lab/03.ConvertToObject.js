function parseObject(str) {
    let person = JSON.parse(str);
   
    for(let key in person){
        console.log(`${key}: ${person[key]}`);
    }
}
parseObject('{"name": "George", "age": 40, "town": "Sofia"}');