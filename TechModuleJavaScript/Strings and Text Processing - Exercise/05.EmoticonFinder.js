function findEmoticon(text) {
    text = text.split(' ');
    for (let t of text) {
        if (t.length === 2 && t.startsWith(':')) {
            console.log(t);
        }
    }
}
findEmoticon('There are so many emoticons nowadays :P I have many ideas :O what input to place here :)');