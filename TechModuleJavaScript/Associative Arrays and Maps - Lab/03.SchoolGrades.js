function printStudents(params) {
    let students = new Map();

    for (let param of params) {
        let tokens = param.split(' ').filter(x => x !== '');
        let name = tokens.shift();
        let grades = tokens.map(Number);
        if (students.has(name)) {
            grades = students.get(name).concat(grades);
        }

        students.set(name, grades);
    }

    let sortedStudents = [...students].sort(function (a, b) {
        let averageA = a[1].reduce((g1, g2) => g1 + g2, 0) / a[1].length;
        let averageB = b[1].reduce((g1, g2) => g1 + g2, 0) / b[1].length;
        return averageA - averageB;
    });

    for(let [student,grades] of sortedStudents){
        console.log(`${student}: ${grades.join(', ')}`);
    }
}
printStudents(['Lilly 4 6 6 5',
    'Tim 5 6',
    'Tammy 2 4 3',
    'Tim 6 6']
);