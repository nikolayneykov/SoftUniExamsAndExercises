function solve (price, vatRate) {
  console.log((price / (1 + vatRate * 0.01)).toFixed(2))
}

solve(120.0, 20.0)
