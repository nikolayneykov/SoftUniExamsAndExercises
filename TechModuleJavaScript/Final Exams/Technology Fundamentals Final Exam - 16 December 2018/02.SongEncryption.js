function solve(params) {
    let regex = /^[A-Z][a-z\s\']+\:[A-Z\s]+$/;

    for (let param of params) {
        if (param === 'end') {
            break;
        }

        if (!param.match(regex)) {
            console.log('Invalid input!');
        } else {
            let encryptionKey = param.split(':')[0].length;
            let encryptedResult = param.split('');

            for (let i = 0; i < encryptedResult.length; i++) {
                let currentSymbol = encryptedResult[i];
                let asciiCode = currentSymbol.charCodeAt(0);
                asciiCode += encryptionKey;
                
                if (currentSymbol.match(/[A-Za-z]/)) {
                    if (currentSymbol.match(/[A-Z]/) && asciiCode > 90) {
                        asciiCode = (asciiCode % 90) + 64;
                    } else if (currentSymbol.match(/[a-z]/) && asciiCode > 122) {
                        asciiCode = (asciiCode % 122) + 96;
                    }

                    encryptedResult[i] = String.fromCharCode(asciiCode);
                }
            }

            console.log(`Successful encryption: ${encryptedResult.join('').replace(':', '@')}`);
        }
    }
}

solve(
    [
        'Michael Jackson:ANOTHER PART OF ME',
        'Adele:ONE AND ONLY',
        'Guns n\'roses:NOVEMBER RAIN',
        'Christina Aguilera: HuRt',
        'end',
    ]
)