function insertDwarfs(text, dwarfs) {
    let index = 0;
    let arr = text.split(' ');
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === 'dwarf') {
            if (dwarfs.length > 0) {
                arr.splice(i + 1, 0, dwarfs.shift());
            } else {
                arr.splice(i, 1);
            }
        }
    }
    console.log(arr.join(' '));
}
insertDwarfs("Yet another dwarf fairytale tragedy! There are dwarf so many dwarfs, is it dwarf possible to help dwarf Show white?",
    ["Doc", "Dopey", "Sleepy"]
);