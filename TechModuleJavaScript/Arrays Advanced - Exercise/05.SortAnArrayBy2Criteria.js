function sort(arr) {
    function sortingCriteria(a, b) {
        let result = a.length - b.length;

        if (result === 0) {
            result = a.localeCompare(b);
        }
        
        return result;
    }

    arr = arr.sort(sortingCriteria);
    console.log(arr.join('\n'));
}
sort(["Isacc", "Theodor","Anie", "Jack",  "Harrison", "George"]);