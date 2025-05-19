let num1 = 0;   
let num2 = 0;
let num3 = 1;

for (let i = 1; i <= 20; i++) {
    num1 = num2;
    num2 = num3;
    num3 = sum(num1, num2);
    console.log(num1);
}

function sum(n1, n2) {
    return n1 + n2;
}