function solve([text, placeholders]) {
    placeholders = placeholders.split(/{|}/).filter(x => x !== '');
    let regex = /([A-Za-z]+)(.+)\1/g;
    let match = regex.exec(text);
    let result = '';

    while (match !== null && placeholders.length>0) {
        let replacement = match[0].replace(match[2],placeholders.shift());

        result = text.replace(match[0],replacement);
        match = regex.exec(text);
        text = result;
    }

    console.log(result)
}

solve(
    [
        'HeypalHey______how_ya_how_doin_how',
        '{first}{second}'
    ]
)