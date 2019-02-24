function printConeData(radius, height) {
    let volume = (Math.PI * radius * radius * height) / 3;
    let slantHeight = Math.sqrt(radius * radius + height * height);
    let surfaceArea = (Math.PI * radius * radius) + Math.PI * radius * slantHeight;
    return `volume = ${volume.toFixed(4)}\narea = ${surfaceArea.toFixed(4)}`;
}
console.log(printConeData(3, 5));