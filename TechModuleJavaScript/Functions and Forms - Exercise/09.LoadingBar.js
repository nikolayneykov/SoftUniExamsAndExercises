function loadBar(percent) {
    let result = `${percent}% `;
    if (percent === 100) {
        result += `Complete!\n[${'%'.repeat(10)}]`;
    } else {
        let completed = '%'.repeat(percent / 10);
        let resedue = '.'.repeat(10 - (percent / 10));
        result += `[${completed + resedue}]\nStill loading...`;
    }

    console.log(result)
}
loadBar(20);