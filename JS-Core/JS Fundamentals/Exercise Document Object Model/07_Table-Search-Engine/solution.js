function solve() {
    let tableRows = Array.from(document.querySelectorAll('tbody tr'));
    let searchField = document.querySelector('#searchField');
    let searchBtn = document.querySelector('#searchBtn');

    searchBtn.addEventListener('click', search);

    function search() {
        let searchedText = searchField.value;

        tableRows.forEach(tr => {
            tr.removeAttribute('class','select');

            if (Array.from(tr.childNodes).some(td => td.textContent.includes(searchedText))) {
                tr.setAttribute('class', 'select');
            }
        });
        
        searchField.value = '';
    }
}