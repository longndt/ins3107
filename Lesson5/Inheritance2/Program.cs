//create parent
using Inheritance2;

ElectronicDevice electronicDevice = new ElectronicDevice("future device", "USA");
Laptop myLaptop = new Laptop("Macbook", "USA", 2999.99, "Silver");
Mobile myMobile = new Mobile("iPhone", "USA", 100, true);

electronicDevice.showDevice();
myLaptop.showDevice();
myMobile.showDevice();