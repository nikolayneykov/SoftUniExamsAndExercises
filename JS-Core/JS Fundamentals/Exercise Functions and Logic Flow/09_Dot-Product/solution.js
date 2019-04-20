function solve() {
    let matrix1 = JSON.parse(document.querySelector('#mat1').value).map(a => a.map(Number));
    let matrix2 = JSON.parse(document.querySelector('#mat2').value).map(a => a.map(Number));
    let result = document.querySelector('#result');


    for (let row1 of matrix1) {

        let currentRow = [];
        for (let row2 of matrix2) {
            let sumOfProducts = row1.map((e, i) => e * row2[i]).reduce((a, b) => a + b, 0);
            currentRow.push(sumOfProducts);
        }

        let p = document.createElement('p');
        p.textContent = currentRow.join(', ');

        result.appendChild(p);
    }
}