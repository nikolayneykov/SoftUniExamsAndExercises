function solve(params) {
    let videos = {};
    let sortingCriteria = params.pop().split(' ')[1];
    params.pop();

    for (let param of params) {
        if (param.includes('-')) {
            let [videoName, viewsCount] = param.split('-');

            if (!videos.hasOwnProperty(videoName)) {
                videos[videoName] = { views: 0, likes: 0 };
            }

            videos[videoName].views += Number(viewsCount);
        } else {
            let [rate, videoName] = param.split(':');

            if (videos.hasOwnProperty(videoName)) {
                videos[videoName].likes += rate === 'like' ? 1 : -1;
            }
        }
    }

    Object.entries(videos)
        .sort((a,b)=>b[1][sortingCriteria]-a[1][sortingCriteria])
        .forEach(v=>console.log(`${v[0]} - ${v[1].views} views - ${v[1].likes} likes`));
}

solve(
    [
        'Eninem Venom-500',
        'like:Eninem Venom',
        'Funny Cats-700',
        'like:Funny Cats',
        'like:Funny Cats',
        'Eninem Venom-300',
        'stats time',
        'by likes'
    ]
);