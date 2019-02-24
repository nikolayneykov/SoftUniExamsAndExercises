function solve(params) {
    let userList = [];
    let articleList = [];
    let commentsData = {};

    for (let p of params) {

        if (p.startsWith('user ')) {
            let username = p.replace('user ', '');
            userList.push(username);
        } else if (p.startsWith('article ')) {
            let articleName = p.replace('article ', '');
            articleList.push(articleName);
        } else {
            let tokens = p.split(/[\s,:]/g).filter(x => x !== '');
            let username = tokens[0];
            let article = tokens[3];

            if (userList.includes(username) && articleList.includes(article)) {
                tokens = p.split(': ');
                let comment = tokens[1].replace(',', ' -');
                if (commentsData[article] === undefined) {
                    commentsData[article] = [];
                }
                commentsData[article].push(`--- From user ${username}: ${comment}`);
            }
        }
    }

    let sortedArticles = Object.keys(commentsData).sort((a, b) => commentsData[b].length - commentsData[a].length);

    for (let article of sortedArticles) {
        console.log(`Comments on ${article}`);
        let sortedComments = Object.keys(commentsData[article]).sort(function (a, b) {
            let aUsername = commentsData[article][a].split(':')[0].replace('--- From user ', '');
            let bUsername = commentsData[article][b].split(':')[0].replace('--- From user ', '');
            return aUsername.localeCompare(bUsername);
        });
        for (let comment of sortedComments) {
            console.log(commentsData[article][comment]);
        }
    }
}
solve(['user aUser123', 'someUser posts on someArticle: NoTitle, stupidComment', 'article Books', 'article Movies', 'article Shopping', 'user someUser', 'user uSeR4', 'user lastUser', 'uSeR4 posts on Books: I like books, I do really like them', 'uSeR4 posts on Movies: I also like movies, I really do', 'someUser posts on Shopping: title, I go shopping every day', 'someUser posts on Movies: Like, I also like movies very much']);