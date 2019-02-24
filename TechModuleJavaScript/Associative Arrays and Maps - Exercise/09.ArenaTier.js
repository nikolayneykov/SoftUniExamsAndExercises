function printGladiators(params) {
    let gladiators = {};
    params.pop();

    for (let param of params) {
        let tokens = param.split(' ');
        let firstGladiator = tokens[0];
        let secondGladiator = tokens[2];
        let separator = tokens[1];
        let technique = tokens[2];
        let skillPoints = Number(tokens[4]);

        if (separator === '->') {
            if (!gladiators.hasOwnProperty(firstGladiator)) {
                gladiators[firstGladiator] = {
                    techniques: {},
                    totalSkillPoints: 0,
                }
            }

            if (!gladiators[firstGladiator].techniques.hasOwnProperty(technique)) {
                gladiators[firstGladiator].techniques[technique] = skillPoints;
                gladiators[firstGladiator].totalSkillPoints += skillPoints;
            } else if (gladiators[firstGladiator].techniques[technique] < skillPoints) {
                gladiators[firstGladiator].totalSkillPoints +=
                    skillPoints - gladiators[firstGladiator].techniques[technique];
                gladiators[firstGladiator].techniques[technique] = skillPoints;
            }
        } else if (separator === 'vs') {
            if (gladiators.hasOwnProperty(firstGladiator) && gladiators.hasOwnProperty(secondGladiator)) {
                let hasCommonTechnique = false;
                let firstTechniques = Object.keys(gladiators[firstGladiator].techniques);
                let secondTechniques = Object.keys(gladiators[secondGladiator].techniques);
                for (let t of firstTechniques) {
                    if (secondTechniques.includes(t)) {
                        hasCommonTechnique = true;
                        break;
                    }
                }

                if (hasCommonTechnique) {
                    if (gladiators[firstGladiator].totalSkillPoints >
                        gladiators[secondGladiator].totalSkillPoints) {
                        delete gladiators[secondGladiator];
                    } else if (gladiators[firstGladiator].totalSkillPoints <
                        gladiators[secondGladiator].totalSkillPoints) {
                        delete gladiators[firstGladiator];
                    }
                }
            }
        }
    }

    let sortedGladiators = Object.entries(gladiators)
        .sort(function (a, b) {
            let result = b[1].totalSkillPoints - a[1].totalSkillPoints;
            if (result === 0) {
                result = a[0].localeCompare(b[0]);
            }
            return result;
        });

    for (let sorted of sortedGladiators) {
        let gladiatorName = sorted[0];
        let totalSkillPoints = sorted[1].totalSkillPoints;
        console.log(`${gladiatorName}: ${totalSkillPoints} skill`);
        let sortedTechniques = Object.entries(sorted[1].techniques)
            .sort(function (a, b) {
                let result = b[1] - a[1];
                if (result === 0) {
                    result = a[0].localeCompare(b[0]);
                }
                return result;
            });

        for (let [technique, skill] of sortedTechniques) {
            console.log(`- ${technique} <!> ${skill}`);

        }
    }
}

printGladiators(['Pesho -> Duck -> 400',
    'Julius -> Shield -> 150',
    'Gladius -> Heal -> 200',
    'Gladius -> Support -> 250',
    'Gladius -> Shield -> 250',
    'Pesho vs Gladius',
    'Gladius vs Julius',
    'Gladius vs Gosho',
    'Ave Cesar']

);