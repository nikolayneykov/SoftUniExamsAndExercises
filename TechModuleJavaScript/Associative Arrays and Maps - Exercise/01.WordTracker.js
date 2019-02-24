function trackWords(params) {
    let trackedWords = {};
    let wordsToTrack = params.shift().split(' ');
    for (let word of wordsToTrack) {
        trackedWords[word]=0;
    }
    
    for(let word of params){
       if (trackedWords.hasOwnProperty(word)) {
           trackedWords[word]++;
       }
    }

    let sortedWords = Object.entries(trackedWords).sort((a,b)=>b[1]-a[1]);
    for(let word of sortedWords){
        console.log(`${word[0]} - ${word[1]}`);
    }
}
trackWords(['this sentence', 'In', 'this', 'sentence',
    'you', 'have', 'to', 'count', 'the', 'occurances',
    'of', 'the', 'words', 'this', 'and', 'sentence',
    'because', 'this', 'is', 'your', 'task','sentence','sentence']
);