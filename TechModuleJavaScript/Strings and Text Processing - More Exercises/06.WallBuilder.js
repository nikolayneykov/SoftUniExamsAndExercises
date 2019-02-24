function buildWall(params) {
    let regexBase = new RegExp(/^[A-Z]+([A-Z]+|\d{4,})*\d{4,}$/);
    for (let i = 0; i < params.length / 3; i++) {
        console.log(regexBase.test(params[i]) ? 'SOLID BASE!' : 'WEAK BASE!');
    }
    let regexMiddle = new RegExp(/^[A-Za-z]{3,}[A-Za-z\%\$\#\@]*[\%\$\#\@]+$/);
    for (let i = params.length / 3; i < params.length / 3 * 2; i++) {
        console.log(regexMiddle.test(params[i]) ? 'SOLID MIDDLE!' : 'WEAK MIDDLE!');
    }
    let regexTop = new RegExp(/^0+(0+|[a-z]{0,5})*0+[a-z]{0,5}$/);
    for (let i = params.length / 3 * 2; i < params.length / 3 * 3; i++) {
        console.log(regexTop.test(params[i]) ? 'SOLID TOP!' : 'WEAK TOP!');
    }
}
buildWall(['SO9000STRONG10000WALL7000', 'YES345345345PLEASEHAHA999999',
    'xaXAxa###MiDDlE%%$##', 'mMmMm%%%%ImRichGuy$$$$$',
    '00000cant0do000that', '0sorry00happy000sad']
);
buildWall([
    'SO9000STRONG10WALL7000', 'YES345345345PLEASEHAHA999999',
    'xaXAxa###MiDDlE%%$##', 'mM%%%%ImRichGuy$$$$$',
    '00000cant0do000that', '0sorry00happy000saaaad'
]
);