function solve(params) {
    let shelfs = {};
    for (let p of params) {
        if (p.includes(' -> ')) {
            let tokens = p.split(' -> ');
            let id = Number(tokens[0]);
            let genre = tokens[1];
            if (shelfs[id] === undefined) {
                shelfs[id] = { shelfGenre: genre, books: [] };
            }
        } else {
            let tokens = p.split(':');
            let bookTitle = tokens[0];
            let bookAuthor = tokens[1].split(', ')[0];
            let bookGenre = tokens[1].split(', ')[1];
            for (let id in shelfs) {
                if (shelfs[id].shelfGenre === bookGenre) {
                    shelfs[id].books.push(`--> ${bookTitle}:${bookAuthor}`);
                }
            }
        }

    }
    let sortedShelfs = Object.keys(shelfs).sort(function (a, b) {
        let aCount = shelfs[a].books.length;
        let bCount = shelfs[b].books.length;
        return bCount - aCount;
    });
    for (let shelf of sortedShelfs) {
        let bookCount = shelfs[shelf].books.length;
        console.log(`${shelf} ${shelfs[shelf].shelfGenre}: ${bookCount}`);
        //TODO sort books
        for (let book of shelfs[shelf].books) {
            console.log(book);
        }
    }
}
solve(['1 -> history', '1 -> action', 'Death in Time: Criss Bell, mystery', '2 -> mystery', '3 -> sci-fi', 'Child of Silver: Bruce Rich, mystery', 'Hurting Secrets: Dustin Bolt, action', 'Future of Dawn: Aiden Rose, sci-fi', 'Lions and Rats: Gabe Roads, history', '2 -> romance', 'Effect of the Void: Shay B, romance', 'Losing Dreams: Gail Starr, sci-fi', 'Name of Earth: Jo Bell, sci-fi', 'Pilots of Stone: Brook Jay, history']);