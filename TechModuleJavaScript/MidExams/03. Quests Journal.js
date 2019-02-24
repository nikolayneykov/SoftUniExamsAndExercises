function printQuests(params) {
    params.pop();
    let questList = params.shift().split(', ');

    for (let param of params) {
        let paramTokens = param.split(' - ');
        let command = paramTokens[0];
        let questTokens = paramTokens[1].split(':');

        let quest = questTokens[0];
        let sideQuest = questTokens[1];
        let index = questList.indexOf(quest);

        if (command === 'Start' && index === -1) {
            questList.push(quest);
        } else if (command === 'Complete' && index !== -1) {
            questList.splice(index, 1);
        } else if (command === 'Side Quest' && index !== -1 && !questList.includes(sideQuest)) {
            questList.splice(index + 1, 0, sideQuest);
        } else if (command === 'Renew' && index !== -1) {
            let renewedQuest = questList.splice(index, 1);
            questList.push(renewedQuest);
        }
    }
    console.log(questList.join(', '));
}
printQuests(['Hello World, If else',
    'Complete - Homework',
    'Side Quest - If else:Switch',
    'Renew - Hello World',
    'Retire!',
]);