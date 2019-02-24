function printChessBoard(n) {
    let result = '<div class="chessboard">';
    let startColor = 'black';
    for (let i = 0; i < n; i++) {
        result += '\n  <div>'
        let color = startColor;
        for (let j = 0; j < n; j++) {
            result += `\n    <span class="${color}"></span>`;
            color = color === 'black' ? 'white' : 'black';
        }
        startColor = startColor === 'black' ? 'white' : 'black';
        result += '\n  </div>'
    }
    result += '\n</div>';
    return result;
}