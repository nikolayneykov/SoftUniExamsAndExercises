function solve() {
    let registerButton = document.querySelector("form button");
    let searchButton = document.querySelector("#exercise > button");
    registerButton.addEventListener("click", register);
    searchButton.addEventListener("click", search);

    function register(e) {
        e.preventDefault();
        let tableBody = document.querySelector('table tbody');
        let userInfo = document.querySelectorAll(".user-info input");
        let username = userInfo[0];
        let email = userInfo[2];
        let topics = Array.from(document.querySelectorAll("#exercise .topics input"))
            .filter(x => x.checked).map(x => x.value);

        let tr = document.createElement("tr");
        let td = document.createElement("td");

        let usernameElement = td.cloneNode();
        usernameElement.textContent = username.value;

        let emailElement = td.cloneNode();
        emailElement.textContent = email.value;

        let topicsElement = td.cloneNode();
        topicsElement.textContent = topics.join(" ");

        tr.appendChild(usernameElement);
        tr.appendChild(emailElement);
        tr.appendChild(topicsElement);

        tableBody.appendChild(tr);
    }

    function search(e) {
        e.preventDefault();
        let searchTerm = document.querySelector('#exercise > input').value;
        let userTable = Array.from(document.querySelectorAll('table tbody tr td'));

        userTable.forEach(element => {
            element.parentNode.style.visibility = 'hidden';
        });

        userTable.forEach(element => {
            if (element.textContent.includes(searchTerm)) {
                element.parentNode.style.visibility = 'visible';
            }
        });
    }
}