function createCat(params) {
    class Cat {
        constructor(name, age) {
            this.catName = name;
            this.catAge = age;
        };
        sayMeow() {
            console.log(`${this.catName}, age ${this.catAge} says Meow`);
        };
    };

    for (let param of params) {
        let tokens = param.split(' ');
        let name = tokens[0];
        let age = tokens[1];
        let currentCat = new Cat(name,age);
        currentCat.sayMeow();
    }
}
createCat(['Mellow 2', 'Tom 5']);