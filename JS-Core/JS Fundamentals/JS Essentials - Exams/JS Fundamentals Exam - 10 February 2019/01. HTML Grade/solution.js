function solve (examPoints, homeworkCompleted, totalHomework) {
  let grade = 0

  if (examPoints === 400) {
    grade = 6
  } else {
    let totalPoints =
      (examPoints / 400) * 90 + (homeworkCompleted / totalHomework) * 10
    grade = 3 + (2 * (totalPoints - 20)) / 50
    grade = grade < 3 ? Math.floor(grade) : Math.min(6, grade)
  }

  console.log(grade.toFixed(2))
}

solve(300, 10, 10)
