//create parent instance
using Inheritance1;

Vehicle vehicle = new Vehicle("demo vehicle", 1999.99, "Black");

//create child instance
Car car = new Car("Camry", 50000, "White", "Toyota", 2024);

//display info
vehicle.displayInfo();

car.displayInfo();
car.displayDetail();