using homework_1;

Book book1 = new Book();
Book book2 = new Book("Dummy", "Jonh Doe", DateTime.Now.Year);

Square square1 = new Square(10);
Square square2 = new Square();

Car car1 = new Car("Audi", "80", 1990);
Car car2 = new Car("Audi", "A5");

Phone phone = new Phone("Samsung", "Galaxy");

Point2D point1 = new Point2D(2, 2);
Point2D point2 = new Point2D(4, 4);

double distance = point1.distance(point2);

BankAccount account = new BankAccount("000007", "John Doe", 100, AccountType.Personal);

try
{
    account.deposit(50);
    account.withdraw(80);
    account.withdraw(200);
}
catch { }

TemperatureHistory temperatures = new TemperatureHistory();
temperatures.addTemperature(30);
temperatures.addTemperature(-10);
temperatures.addTemperature(20);

temperatures.removeTemperature(1);

double averageTemperature = temperatures.averageTemperature();

Console.WriteLine("Debug");
