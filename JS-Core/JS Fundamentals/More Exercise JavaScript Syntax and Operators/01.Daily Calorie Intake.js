function printCalories([sex, weight, height, age], workouts) {
    let calories = 0;

    if (sex === 'm') {
        calories = 66 + 13.8 * weight + 5 * height - 6.8 * age;
    } else if (sex === 'f') {
        calories = 655 + 9.7 * weight + 1.85 * height - 4.7 * age;
    }

    let activityFactor = 1.2;

    if (workouts >= 1 && workouts <= 2) {
        activityFactor = 1.375;
    } else if (workouts >= 3 && workouts <= 5) {
        activityFactor = 1.55;
    } else if (workouts >= 6 && workouts <= 7) {
        activityFactor = 1.725;
    } else if (workouts > 7) {
        activityFactor = 1.90;
    }

    calories = Math.round(calories * activityFactor);
    console.log(calories);
}

printCalories(['f', 46, 157, 32], 5);