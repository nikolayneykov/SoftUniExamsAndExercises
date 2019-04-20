function solve() {
    let products = new Set();
    let total = 0;
    let textArea = document.getElementsByTagName("textarea")[0];
    let addToCartButtons = Array.from(document.querySelectorAll(".product button"));
    let buyButton = document.getElementsByTagName("button")[3];

    buyButton.addEventListener("click", buy);

    addToCartButtons.forEach(button => button.addEventListener("click", addToCart));

    function addToCart(e) {
        let product = e.target.parentNode.children;
        let name = product[1].textContent;
        let price = product[2].textContent.split(" ")[1];
        products.add(name);
        total += Number(price);

        textArea.textContent += `Added ${name} for ${price} to the cart.\n`;
    }

    function buy() {
        textArea.textContent += `You bought ${Array.from(products).join(", ")} for ${total.toFixed(2)}.\n`;
    }
}