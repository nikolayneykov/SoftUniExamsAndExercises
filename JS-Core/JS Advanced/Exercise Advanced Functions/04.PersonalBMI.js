function solve (name, age, weight, height) {
  function getBmi (weightKg, heightM) {
    return Math.round(weightKg / heightM ** 2)
  }

  function getStatus (bmi) {
    let status = ''
    if (bmi < 18.5) {
      status = 'underweight'
    } else if (bmi >= 18.5 && bmi < 25) {
      status = 'normal'
    } else if (bmi >= 25 && bmi < 30) {
      status = 'overweight'
    } else if (bmi >= 30) {
      status = 'obese'
    }

    return status
  }

  let person = {
    name,
    personalInfo: {
      age,
      weight,
      height
    },
    BMI: getBmi(weight, height / 100)
  }

  person.status = getStatus(person.BMI)

  if (person.status === 'obese') {
    person.recommendation = 'admission required'
  }

  return person
}

solve('Honey Boo Boo', 9, 57, 137)
