 function calculateTime(steps, stepSize, speed) {
    let distanceInKm = steps * stepSize / 1000;
    let totalSeconds = distanceInKm / speed * 3600;
    totalSeconds += Math.floor(distanceInKm / 0.5) * 60;
    let hours = '0' + Math.floor(totalSeconds / 3600);
    let minutes = '0' + Math.floor(totalSeconds / 60);
    let seconds = '0' + Math.round(totalSeconds % 60);

    console.log(`${hours.slice(hours.length-2)}:${minutes.slice(minutes.length-2)}:${seconds.slice(seconds.length-2)}`);
}

calculateTime(2564, 0.70, 5.5);