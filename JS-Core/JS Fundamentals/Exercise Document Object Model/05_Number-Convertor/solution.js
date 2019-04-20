function solve() {   
    let input = document.querySelector('#input');
    let selectMenuTo = document.querySelector('#selectMenuTo');
    selectMenuTo.innerHTML = '';
    
    let binaryOption = document.createElement('option');
    binaryOption.setAttribute('value','binary');
    binaryOption.textContent = 'Binary';

    let hexadecimalOption = document.createElement('option');
    hexadecimalOption.setAttribute('value','hexadecimal');
    hexadecimalOption.textContent = 'Hexadecimal';

    selectMenuTo.appendChild(binaryOption);
    selectMenuTo.appendChild(hexadecimalOption);

    let result = document.querySelector('#result');
    document.querySelector('button').addEventListener('click',convert);


    function convert() {
        if (selectMenuTo.value ==='binary') {
            result.value = Number(input.value).toString(2);
        }else if(selectMenuTo.value ==='hexadecimal'){
            result.value = Number(input.value).toString(16).toUpperCase();
        }
    }
}