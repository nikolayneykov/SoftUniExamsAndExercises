function solve (params) {
  const engines = [
    { power: 90, volume: 1800 },
    { power: 120, volume: 2400 },
    { power: 200, volume: 3500 }
  ]

  const carriages = {
    hatchback: { type: 'hatchback', color: params.color },
    coupe: { type: 'coupe', color: params.color }
  }

  const wheels = Array.from({ length: 4 }, () =>
    params.wheelsize % 2 === 1 ? params.wheelsize : params.wheelsize - 1
  )

  return {
    model: params.model,
    engine: engines.find(e => e.power >= params.power),
    carriage: carriages[params.carriage],
    wheels
  }
}

console.log(
  solve({ model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14 })
)
