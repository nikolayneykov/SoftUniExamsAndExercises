function solve(params) {
    let result = [];
    for (let p of params) {
        let entries = Object.entries(JSON.parse(p))[0];
        let key = entries[0].toString();
        let value = entries[1].toString();

        let hasObj = result.find(x => x.term === key);
        if (hasObj) {
            hasObj.description = value;
        } else {
            let obj = {
                term: key,
                description: value,
                compareTo: function (other) {
                    return this.term > other.term;
                },
                toString: function () {
                    return 'Term: ' + this.term + ' => Definition: ' + this.description;
                },
            }
            result.push(obj);
        }
    }
    result.sort((a, b) => a.compareTo(b));
    for (let r of result) {
        console.log(r.toString());
    }
}
solve(['{"Coffee":"A hot drink made from the roasted and ground seeds (coffee beans) of a tropical shrub."}',
    '{"Bus":"A large motor vehicle carrying passengers by road, typically one serving the public on a fixed route and for a fare."}',
    '{"Boiler":"A fuel-burning apparatus or container for heating water."}',
    '{"Tape":"A narrow strip of material, typically used to hold or fasten something."}',
    '{"Microphone":"An instrument for converting sound waves into electrical energy variations which may then be amplified, transmitted, or recorded."}']
)