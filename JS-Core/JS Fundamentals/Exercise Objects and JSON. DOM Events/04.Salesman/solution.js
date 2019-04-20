function solve() {
  let textAreas = document.getElementsByTagName("textarea");
  let buttons = document.getElementsByTagName("button");
  let logTextArea = textAreas[2];
  let profit = 0;
  buttons[0].addEventListener("click", load);
  buttons[1].addEventListener("click", buy);
  buttons[2].addEventListener("click", endDay);

  let products = [];

  function load() {
    let inputTextArea = JSON.parse(textAreas[0].value);
    inputTextArea.forEach(element => {
      if (products.some(p => p.name === element.name)) {
        products.find(p => p.name === element.name).quantity += element.quantity;
        products.find(p => p.name === element.name).price = element.price;
      } else {
        products.push(element);
      }

      logTextArea.value += `Successfully added ${element.quantity} ${element.name}. Price: ${element.price}\n`;
    });
  }

  function buy() {
    let obj = JSON.parse(textAreas[1].value);
    let product = products.find(p => p.name === obj.name);
    if (product && product.quantity >= obj.quantity) {
      products.find(p => p.name === obj.name).quantity -= obj.quantity;
      profit += obj.quantity * product.price;
      logTextArea.value += `${obj.quantity} ${obj.name} sold for ${obj.quantity * product.price}.\n`;
    } else {
      logTextArea.value += "Cannot complete order.\n";
    }
  }

  function endDay() {
    logTextArea.value += `Profit: ${profit.toFixed(2)}.\n`;
    buttons[0].removeEventListener("click", load);
    buttons[1].removeEventListener("click", buy);
    buttons[2].removeEventListener("click", endDay);
  }
}