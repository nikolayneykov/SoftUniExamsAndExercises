function systemRegister(params) {
    let systems = {};

    for (let param of params) {
        let tokens = param.split(' | ').filter(x => x !== '');
        let currentSystem = tokens[0];
        let currentComponent = tokens[1];
        let currentSubcomponent = tokens[2];

        if (!systems.hasOwnProperty(currentSystem)) {
            systems[currentSystem] = {};
        }
        if (!systems[currentSystem].hasOwnProperty(currentComponent)) {
            systems[currentSystem][currentComponent] = [];
        }
        systems[currentSystem][currentComponent].push(currentSubcomponent);
    }

    let sortedSystemKeys = Object.keys(systems).sort(function (a, b) {
        let result = Object.keys(systems[b]).length - Object.keys(systems[a]).length;
        if (result === 0) {
            result = a.localeCompare(b);
        }
        return result;
    });

    for (let systemKey of sortedSystemKeys) {
        console.log(systemKey);
        let sortedComponentKeys = Object.keys(systems[systemKey]).sort(function (a, b) {
            return systems[systemKey][b].length - systems[systemKey][a].length;
        });
        for (let componentKey of sortedComponentKeys) {
            console.log('|||' + componentKey);
            let subcomponentKeys = systems[systemKey][componentKey];
            for (let subcomponentKey of subcomponentKeys) {
                console.log('||||||' + subcomponentKey);
            }
        }
    }
}
systemRegister([
    'SULS | Main Site | Home Page',
    'SULS | Main Site | Login Page',
    'SULS | Main Site | Register Page',
    'SULS | Judge Site | Login Page',
    'SULS | Judge Site | Submittion Page',
    'Lambda | CoreA | A23',
    'SULS | Digital Site | Login Page',
    'Lambda | CoreB | B24',
    'Lambda | CoreA | A24',
    'Lambda | CoreA | A25',
    'Lambda | CoreC | C4',
    'Indice | Session | Default Storage',
    'Indice | Session | Default Security',
]
)