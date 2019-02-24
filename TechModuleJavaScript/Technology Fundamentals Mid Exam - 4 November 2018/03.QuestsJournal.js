function solve(params) {
    let journal = params.shift().split(', ').filter(x => x !== '');

    for (let p of params) {
        if (p === 'Retire!') {
            break;
        }
        let tokens = p.split(' - ').filter(x => x !== '');
        let command = tokens[0];
        if (command === 'Start') {
            let quest = tokens[1];
            if (!journal.includes(quest)) {
                journal.push(quest);
            }
        } else if (command === 'Complete') {
            let quest = tokens[1];
            journal = journal.filter(x => x !== quest);
        } else if (command === 'Side Quest') {
            let sideQuestTokens = tokens[1].split(':').filter(x => x !== '');
            let quest = sideQuestTokens[0];
            let sideQuest = sideQuestTokens[1];
            let index = journal.indexOf(quest);
            if (!journal.includes(sideQuest) && index !== -1) {
                journal.splice(index+1, 0, sideQuest);
            }
        } else if (command === 'Renew') {
            let quest = tokens[1];
            if (journal.includes(quest)) {
                journal = journal.filter(x => x !== quest);
                journal.push(quest);
            }
        }
    }
    console.log(journal.join(', '));
}
solve(['Hello World, If else',
    'Complete - Homework',
    'Side Quest - If else:Switch',
    'Renew - Hello World',
    'Retire!',
]);