function concatenate(params) {
    let result = '';
    params.forEach(x => result += x);
    console.log(result);
}
concatenate(["First",
    "Second",
    "Third"]
);