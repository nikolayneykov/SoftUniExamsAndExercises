function binarySearch() {
    let arr = document.querySelector('#arr').value.split(', ').map(Number);
    let num = +document.querySelector('#num').value;

    let index = -1;
    let leftIndex = 0;
    let rightIndex = arr.length - 1;

    while (leftIndex <= rightIndex) {
        let middleIndex = Math.floor((leftIndex + rightIndex) / 2);

        if (arr[middleIndex] < num) {
            leftIndex = middleIndex + 1;
        } else if (arr[middleIndex] > num) {
            rightIndex = middleIndex - 1;
        }else{
            index = middleIndex;
            break;
        }
    }

    document.querySelector('#result').textContent = index !== -1
        ? `Found ${num} at index ${index}`
        : `${num} is not in the array`;
}
