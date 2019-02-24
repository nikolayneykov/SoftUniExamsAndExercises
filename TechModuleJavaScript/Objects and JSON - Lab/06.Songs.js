function createSong(params) {
    class Song {
        constructor(songType, name, time) {
            this.songType = songType;
            this.name = name;
            this.time = time;
        };
    };

    let songs = [];

    for (let i = 1; i < params.length - 1; i++) {
        let tokens = params[i].split('_');
        let songType = tokens[0];
        let songName = tokens[1];
        let songTime = tokens[2];
        let currentSong = new Song(songType, songName, songTime);
        songs.push(currentSong);
    }
    let songType = params[params.length - 1];
    if (songType !== 'all') {
        songs = songs.filter(song => song.songType === songType);
    }

    songs.forEach(song => console.log(song.name));
}

createSong([3,
    'favourite_DownTown_3:14',
    'favourite_Kiss_4:16',
    'favourite_Smooth Criminal_4:01',
    'alabala_tralala_0:01',
    'favourite']
);