function main() {
    let a = 1;
    let b;
    let range = "";

    b = a + 1;

    for (let i=0; i < 9; i++) {
        if ( i % 2 === 0) {
            console.log("Modulo 2 of " + i + " is zero!")
        }
        range += i + ", ";
    }

    console.info("Hello World");
    console.info(range.substring(0, range.length - 2));
    console.info(a, b);
    console.info(Date())
}
main();