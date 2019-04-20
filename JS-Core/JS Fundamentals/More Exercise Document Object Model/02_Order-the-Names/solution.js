function solve() {
    let input = document.querySelector('input');
    let list = document.querySelectorAll('li');
    document.querySelector('button').addEventListener('click', register);

    function register() {
        if (input !== '') {
            let name = input.value[0].toUpperCase() + input.value.slice(1);
            let position = input.value.toLowerCase().charCodeAt(0) - 97;
            let registeredPeople = [...list[position].textContent.split(', ').filter(x => x !== ''), name];
            list[position].textContent = registeredPeople.join(', ');
            input.value = '';
        }
    }
}
