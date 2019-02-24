function printUniqueNames(inputArr) {
    function sortingCriteria(a, b) {
        let result = a.length - b.length;
        if (result === 0) {
            result = a.localeCompare(b);
        }
        return result;
    }
    let result = inputArr.filter((e, i, arr) => i === arr.indexOf(e)).sort(sortingCriteria);
    console.log(result.join('\n'));
}

printUniqueNames(["Ashton", 
    "Kutcher",
    "Ariel",
    "Lilly",
    "Keyden",
    "Aizen",
    "Billy",
    "Braston",
]
);