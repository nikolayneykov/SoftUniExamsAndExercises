function solve(obj, arr) {
    for (let line of arr) {

        if (line === 'Clear History and Cache') {
            obj['Open Tabs'] = [];
            obj['Recently Closed'] = [];
            obj['Browser Logs'] = [];
        } else if (line.startsWith('Open')) {
            obj['Open Tabs'].push(line.slice(5));
            obj['Browser Logs'].push(line);
        } else if (line.startsWith('Close')) {
            let site = line.slice(6);
            let index = obj['Open Tabs'].indexOf(site)
            if (index !== -1) {
                obj['Open Tabs'].splice(index, 1);
                obj['Recently Closed'].push(site);
                obj['Browser Logs'].push(line);
            }
        }
    }
    obj.toString = function () {
        return this['Browser Name'] +
            `\nOpen Tabs: ${this['Open Tabs'].join(', ')}` +
            `\nRecently Closed: ${this['Recently Closed'].join(', ')}` +
            `\nBrowser Logs: ${this['Browser Logs'].join(', ')}`;
    }
    console.log(obj.toString());
}
solve({
    "Browser Name": "Google Chrome", "Open Tabs": ["Facebook", "YouTube", "Google Translate"],
    "Recently Closed": ["Yahoo", "Gmail"],
    "Browser Logs": ["Open YouTube", "Open Yahoo", "Open Google Translate", "Close Yahoo", "Open Gmail", "Close Gmail", "Open Facebook"]
},
    ["Close Facebook", "Open StackOverFlow", "Open Google"]
);