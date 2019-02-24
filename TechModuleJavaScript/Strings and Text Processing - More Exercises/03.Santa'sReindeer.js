function findReindeer(text) {
    let arr = text.split(' ');
    let reindeers = [];
    for (let i = 0; i < arr.length; i++) {
        let word = arr[i];
        if (word.startsWith('*') && word.endsWith('*')
            && word[1] === word[1].toUpperCase() &&
            word.slice(2) === word.slice(2).toLowerCase()) {
            reindeers.push(word);
            arr.splice(i, 1);
            i--;
        }
    }
    console.log(reindeers.join(', ') + '\n' + '*'.repeat(20) + '\n' + arr.join(' '));
}
findReindeer("Oh my *Rudolf* dwarfs! This *Dasher* year's christmas *Prancer is about to be Comet* ruined because Santa has lost his deer and.");