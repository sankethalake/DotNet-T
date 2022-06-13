var message: string = 'Hello, World!';
console.log(message);


let x = function mul(x: number, y: number){
    return x*y;
}
console.log(x);
let greet = () => console.log("Hello");
greet();

let sum = (a: number,b: number) =>{
    return a+b;
}

console.log(sum(1,2));