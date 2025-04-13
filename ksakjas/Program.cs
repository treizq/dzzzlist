using ksakjas;

public class Program
{
    public static void Main()
    {
        //11111111111
        TransportRental<Scooter> scooterRental = new TransportRental<Scooter>
        {
            ClientName = "Иван Иванов",
            Transport = new Scooter { Model = "Xiaomi Mi Scooter", Year = 2022 },
            RentalTime = 30
        };

        Console.WriteLine("информация об аренде самоката:");
        Console.WriteLine(scooterRental.GetRentalInfo());
        Console.WriteLine($"общая стоимость аренды: {scooterRental.CalculateTotalCost():C2}р\n"); // Форматирование валюты

        TransportRental<Car> carRental = new TransportRental<Car>
        {
            ClientName = "Петр Петров",
            Transport = new Car { LicensePlate = "A123BC", Brand = "Toyota", Model = "Corolla", Color = "Черный" },
            RentalTime = 120
        };

        Console.WriteLine("информация об аренде автомобиля:");
        Console.WriteLine(carRental.GetRentalInfo());
        Console.WriteLine($"общая стоимость аренды: {carRental.CalculateTotalCost():C2}р\n\n"); // Форматирование валюты



        //2222222
        GameCharacter<Sword> swordCharacter = new GameCharacter<Sword>
        {
            Name = "Александр",
            Race = "человек",
            Weapon = new Sword { Quality = "уникальное", Power = 15 },
            Strength = 20
        };

        Console.WriteLine("информация о персонаже с мечом:");
        Console.WriteLine(swordCharacter.GetCharacterInfo());
        Console.WriteLine($"суммарная сила: {swordCharacter.CalculateTotalStrength()}\n");

        GameCharacter<Bow> bowCharacter = new GameCharacter<Bow>
        {
            Name = "Эльвира",
            Race = "эльф",
            Weapon = new Bow { Range = 80, Accuracy = 90 },
            Strength = 18
        };

        Console.WriteLine("информация о персонаже с луком:");
        Console.WriteLine(bowCharacter.GetCharacterInfo());
        Console.WriteLine($"суммарная сила: {bowCharacter.CalculateTotalStrength()}");


        //3333333
        EssentialGoods bread = new EssentialGoods
        {
            ProductName = "хлеб",
            Price = 50.00m
        };

        Console.WriteLine("информация о товаре первой необходимости:");
        bread.Print();
        Console.WriteLine();

        LuxuryGoods watch = new LuxuryGoods
        {
            ProductName = "часы",
            Price = 15000.00m
        };

        Console.WriteLine("информация о товаре роскоши:");
        watch.Print();




        //444444444444
        Manager manager = new Manager
        {
            FullName = "иванов Иван Иванович",
            WorkingDays = 20
        };

        Console.WriteLine("информация о менеджере:");
        manager.Print();
        Console.WriteLine();

        DepartmentHead head = new DepartmentHead
        {
            FullName = "Петров Петр Петрович",
            WorkingDays = 22
        };

        Console.WriteLine("информация о главе отдела:");
        head.Print();
        Console.WriteLine();

        Accounting accounting = new Accounting();
        decimal managerTax = accounting.CalculateIncomeTax(manager, 20);
        decimal headTax = accounting.CalculateIncomeTax(head, 22);

        Console.WriteLine($"подоходный налог для менеджера: {managerTax:C2}");
        Console.WriteLine($"подоходный налог для главы отдела: {headTax:C2}");



        //55555555555555555555
        List<Cars> cars = new List<Cars>
        {
            new Cars { VIN = "12345", Brand = "Toyota", Model = "Corolla", Year = 2015, Color = "Black" },
            new Cars { VIN = "67890", Brand = "Honda", Model = "Civic", Year = 2018, Color = "White" },
            new Cars { VIN = "11223", Brand = "Ford", Model = "Focus", Year = 2012, Color = "Blue" },
            new Cars { VIN = "44556", Brand = "BMW", Model = "X5", Year = 2020, Color = "Red" },
            new Cars { VIN = "77889", Brand = "Audi", Model = "A4", Year = 2019, Color = "Gray\n" }
        };

        Console.WriteLine("список машин:");
        foreach (var car1 in cars)
        {
            Console.WriteLine(car1.Info);
        }
        Console.WriteLine();

        Console.WriteLine("добавление новой машины:");
        Console.Write("введите VIN: ");
        string vin = Console.ReadLine();
        Console.Write("введите марку: ");
        string brand = Console.ReadLine();
        Console.Write("введите модель: ");
        string model = Console.ReadLine();
        Console.Write("введите год выпуска: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("введите цвет: ");
        string color = Console.ReadLine();

        Cars newCar = new Cars { VIN = vin, Brand = brand, Model = model, Year = year, Color = color };
        cars.Add(newCar);

        Console.WriteLine("\nсписок машин после добавления:");
        foreach (var car in cars)
        {
            Console.WriteLine(car.Info);
        }
        Console.WriteLine();

        cars = cars.OrderBy(c => c.Year).ToList();

        Console.WriteLine("список машин после сортировки по году выпуска:");
        foreach (var car in cars)
        {
            Console.WriteLine(car.Info);
        }
        Console.WriteLine();

        Console.Write("введите VIN для поиска и удаления: ");
        string searchVIN = Console.ReadLine();

        Cars carsToRemove = cars.FirstOrDefault(c => c.VIN == searchVIN);
        if (carsToRemove.VIN != null)
        {
            cars.Remove(carsToRemove);
            Console.WriteLine($"машина с VIN {searchVIN} удалена.");
        }
        else
        {
            Console.WriteLine($"машина с VIN {searchVIN} не найдена.");
        }

        Console.WriteLine("\nсписок машин после удаления:");
        foreach (var car in cars)
        {
            Console.WriteLine(car.Info);
        }


        //66666666666666666666
        List<Employee> employees = new List<Employee>
        {
            new Employee { LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Position = "Менеджер", YearOfHiring = 2015 },
            new Employee { LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", Position = "Разработчик", YearOfHiring = 2018 },
            new Employee { LastName = "Сидоров", FirstName = "Сидор", MiddleName = "Сидорович", Position = "Директор", YearOfHiring = 2012 },
            new Employee { LastName = "Кузнецов", FirstName = "Алексей", MiddleName = "Алексеевич", Position = "Аналитик", YearOfHiring = 2020 },
            new Employee { LastName = "Смирнов", FirstName = "Сергей", MiddleName = "Сергеевич", Position = "Тестировщик", YearOfHiring = 2019 }
        };

        Console.WriteLine("список сотрудников:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Info);
        }
        Console.WriteLine();

        Console.WriteLine("добавление нового сотрудника:");
        Console.Write("введите фамилию: ");
        string lastName = Console.ReadLine();
        Console.Write("введите имя: ");
        string firstName = Console.ReadLine();
        Console.Write("введите отчество: ");
        string middleName = Console.ReadLine();
        Console.Write("введите должность: ");
        string position = Console.ReadLine();
        Console.Write("введите год принятия на работу: ");
        int yearOfHiring = int.Parse(Console.ReadLine());

        Employee newEmployee = new Employee
        {
            LastName = lastName,
            FirstName = firstName,
            MiddleName = middleName,
            Position = position,
            YearOfHiring = yearOfHiring
        };
        employees.Add(newEmployee);

        Console.WriteLine("\nсписок сотрудников после добавления:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Info);
        }
        Console.WriteLine();

        employees = employees.OrderBy(e => e.LastName).ToList();

        Console.WriteLine("список сотрудников после сортировки по фамилии:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Info);
        }
        Console.WriteLine();

        Console.Write("введите фамилию для поиска и удаления: ");
        string searchLastName = Console.ReadLine();
        Console.Write("введите имя для поиска и удаления: ");
        string searchFirstName = Console.ReadLine();
        Console.Write("введите отчество для поиска и удаления: ");
        string searchMiddleName = Console.ReadLine();

        Employee employeeToRemove = employees.FirstOrDefault(e =>
            e.LastName == searchLastName &&
            e.FirstName == searchFirstName &&
            e.MiddleName == searchMiddleName);

        if (!string.IsNullOrEmpty(employeeToRemove.LastName))
        {
            employees.Remove(employeeToRemove);
            Console.WriteLine($"сотрудник {searchLastName} {searchFirstName} {searchMiddleName} удален.");
        }
        else
        {
            Console.WriteLine("сотрудник не найден.");
        }

        Console.WriteLine("\nсписок сотрудников после удаления:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.Info);
        }
    }
}