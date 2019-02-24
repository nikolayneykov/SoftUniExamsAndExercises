function solve(params) {
    let result = [];
    for (let p of params) {
        let studentData = p.split(', ');
        let studentName = studentData[0].split(': ')[1];
        let studentGrade = Number(studentData[1].split(': ')[1]);
        let studentAverageScore = Number(studentData[2].split(': ')[1]);
        if (studentAverageScore >= 3) {
            let currentGrade = result.find(x => x.grade === studentGrade + 1);
            if (!currentGrade) {
                result.push({
                    grade: studentGrade + 1,
                    listOfStudents: [],
                    studentScoreSum: 0,
                    averageAnualGrades: function () {
                        return this.studentScoreSum / this.listOfStudents.length;
                    },
                    compareTo: function (other) {
                        return this.grade - other.grade;
                    },
                    toString: function () {
                        return `${this.grade} Grade\n` +
                            `List of students: ${this.listOfStudents.join(', ')}\n` +
                            `Average annual grade from last year: ${this.averageAnualGrades().toFixed(2)}\n`;
                    }
                });
            }
            currentGrade = result.find(x => x.grade === studentGrade + 1);
            currentGrade.listOfStudents.push(studentName);
            currentGrade.studentScoreSum += studentAverageScore;
        }
    }
    result.sort((a, b) => a.compareTo(b));
    for (let grade of result) {
        console.log(grade.toString());
    }
}

solve(["Student name: Mark, Grade: 8, Graduated with an average score: 4.75",
    "Student name: Ethan, Grade: 9, Graduated with an average score: 5.66",
    "Student name: George, Grade: 8, Graduated with an average score: 2.83",
    "Student name: Steven, Grade: 10, Graduated with an average score: 4.20",
    "Student name: Joey, Grade: 9, Graduated with an average score: 4.90",
    "Student name: Angus, Grade: 11, Graduated with an average score: 2.90",
    "Student name: Bob, Grade: 11, Graduated with an average score: 5.15",
    "Student name: Daryl, Grade: 8, Graduated with an average score: 5.95",
    "Student name: Bill, Grade: 9, Graduated with an average score: 6.00",
    "Student name: Philip, Grade: 10, Graduated with an average score: 5.05",
    "Student name: Peter, Grade: 11, Graduated with an average score: 4.88",
    "Student name: Gavin, Grade: 10, Graduated with an average score: 4.00"]
);