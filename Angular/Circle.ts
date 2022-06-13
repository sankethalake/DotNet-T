const pi = 3.14;
//let radius = 4
//console.log("area of circle of radius " + radius+ " is "+ radius*radius*pi );

class Circle{
    radius:number;
    constructor(radius: number){
        this.radius = radius;
    }

    calculateRadius(){
        return pi*this.radius*this.radius;
    }
}
var stu = new Circle(4);
console.log(stu.calculateRadius());