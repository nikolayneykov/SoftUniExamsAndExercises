function solve([text]) {
    let didiRegex = /[^A-Za-z\-]+/;
    let bojoRegex = /[A-Za-z]+-[A-Za-z]+/;
    let match = '';


    while (true) {
        match = text.match(didiRegex);

        if (!match) {
            break;
        }

        console.log(match[0]);
        text = text.slice(match.index + match[0].length);

        match = text.match(bojoRegex);

        if (!match) {
            break;
        }

        console.log(match[0]);
        text = text.slice(match.index + match[0].length);
    }
}

solve(
    ['!.!asd-asd---??!chuuuu!!!asd-dsa']
)