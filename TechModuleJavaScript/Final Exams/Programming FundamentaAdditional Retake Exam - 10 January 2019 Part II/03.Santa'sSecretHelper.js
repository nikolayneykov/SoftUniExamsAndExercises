function solve(params) {
    let key = +params.shift();
    params.pop();
    let regex = /@([A-Za-z]+)[^\@\-!:>]*!G!/;

    for (let param of params) {
        let decryptedInfo = param.split('')
            .map(c => String.fromCharCode(c.charCodeAt(0) - key))
            .join('');

        let result = decryptedInfo.match(regex);
        if (result) {
            console.log(result[1]);
        }
    }
}

solve(
    ['4',
        '~lwzjkl~jenlymfDFsffmiCwozwlzjln%K%',
        '0zfjrl}xnrlDWeqqmi/wnznlwzjnn%K%onhfhnf',
        ';:<lyiljz{onzDPere=;=9<;8=rhknlf%K%',
        'Wonvfkmwzkmpwvzkm\'lhjnlDWeqerxle0wlnzj{nz%K%nohwn',
        'DReh}e=<4lhzj1%K%',
        'end']
)