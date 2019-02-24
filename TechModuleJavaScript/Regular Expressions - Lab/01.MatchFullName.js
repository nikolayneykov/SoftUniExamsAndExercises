function matchFullName(names) {
    let regex = new RegExp(/\b[A-Z][a-z]+ [A-Z][a-z]+\b/, 'g');
    let matches = [];
    let currentMatch = '';
    while (currentMatch = regex.exec(names)) {
            matches.push(currentMatch[0]);
    }
    console.log(matches.join(' '));
}
matchFullName('Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov');