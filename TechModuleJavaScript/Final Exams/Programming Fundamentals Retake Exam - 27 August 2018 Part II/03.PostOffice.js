function solve(params) {
    let [firstPart, secondPart, thirdPart] = params[0].split('|');
    let asciiSymbols = firstPart.match(/([#$%*&])([A-Z]+)(\1)/)[2]
        .split('')
        .map(c => c.charCodeAt(0));

    asciiSymbols.forEach(s => {
        let length = secondPart.match(new RegExp(`${s}:([0-9]{2})`));
        length = Number(length[1]);
        let match = thirdPart.match(new RegExp(`(^|\\s)(${String.fromCharCode(s)}.{${length}})($|\\s)`));  
        
        console.log(match[0])
    });
}

solve(
    ['Urgent"Message.TO$#POAML#|readData79:05:79:0!2reme80:03--23:11{79:05}tak{65:11ar}!77:!23--)77:05ACCSS76:05ad|Remedy Por Ostream :Istream Post sOffices Office Of Ankh-Morpork MR.LIPWIG Mister Lipwig']
)