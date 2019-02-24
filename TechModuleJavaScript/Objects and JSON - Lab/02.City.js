function createCityObject(name, area, population, country, postCode) {
    let city = {
        name, area, population, country, postCode
    };

    for (let key in city) {
        console.log(`${key} -> ${city[key]}`);
    }
}
createCityObject("Sofia", " 492", "1238438", "Bulgaria", "1000");