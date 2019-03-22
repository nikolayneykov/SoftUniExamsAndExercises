function solve(params) {
    let keys = params[0].split('&');
    let regex = /^([A-Za-z\d]{16})|([A-Za-z\d]{25})$/
    let validKeys = [];

    for (let key of keys) {
        if (key.match(regex)) {
            let validKey = key.toUpperCase().split('');

            for (let i = 0; i < validKey.length; i++) {
                if (Number.isInteger(+validKey[i])) {
                    validKey[i] = 9 - Number(validKey[i]);
                }
            }

            let chunkSize = validKey.length === 16 ? 4 : 5;
            validKey  = validKey.join('').match(new RegExp(`.{${chunkSize}}`,'g')).join('-');
            validKeys.push(validKey);
        }
    }

    console.log(validKeys.join(', '));
}

solve(
    ['xPt8VYhUDalilWLvb6uMSGEEf&KWQ{R.@/HZCbbV++1o]V+oG@@fF^93&y6fT5EGFgZHqlFiS']
)