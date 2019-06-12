function attachEventsListeners () {
  document.getElementById('convert').addEventListener('click', calculate)

  function calculate () {
    let inputUnit = document.getElementById('inputUnits').value
    let distance = document.getElementById('inputDistance').value
    switch (inputUnit) {
      case 'km':
        distance *= 1000
        break
      case 'cm':
        distance *= 0.01
        break
      case 'mm':
        distance *= 0.001
        break
      case 'mi':
        distance *= 1609.34
        break
      case 'yrd':
        distance *= 0.9144
        break
      case 'ft':
        distance *= 0.3048
        break
      case 'in':
        distance *= 0.0254
        break
    }

    let outputUnit = document.getElementById('outputUnits').value
    switch (outputUnit) {
      case 'km':
        distance /= 1000
        break
      case 'cm':
        distance /= 0.01
        break
      case 'mm':
        distance /= 0.001
        break
      case 'mi':
        distance /= 1609.34
        break
      case 'yrd':
        distance /= 0.9144
        break
      case 'ft':
        distance /= 0.3048
        break
      case 'in':
        distance /= 0.0254
        break
    }

    document.getElementById('outputDistance').value = distance
  }
}
