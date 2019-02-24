function solve(n) {
    let dna = 'ATCGTTAGGG';
    let index = 0;
    while (n > 0) {
        for (let i = 0; i <= 2; i++) {
            console.log('*'.repeat(2 - i) + dna[index] + '-'.repeat(i * 2) + dna[index + 1] + '*'.repeat(2 - i));
            n--;
            if (n == 0) {
                return;
            } else {
                index += 2;
                if (index > dna.length - 1) {
                    index = 0;
                }
            }
        }
        console.log('*' + dna[index] + '--' + dna[index + 1] + '*');
        n--;
        index += 2;
        if (index > dna.length - 1) {
            index = 0;
        }
    }

}