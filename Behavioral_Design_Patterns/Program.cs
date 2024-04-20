using Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility;
using Behavioral_Design_Patterns.Pirates.Command_Pattern;
using Behavioral_Design_Patterns.Pirates.Iterator;
using Behavioral_Design_Patterns.Pirates.Mediator;
using Behavioral_Design_Patterns.Pirates.Memento;
using Behavioral_Design_Patterns.Pirates.Observer;
using Behavioral_Design_Patterns.Pirates.State;
using Behavioral_Design_Patterns.Pirates.Strategy;
using Behavioral_Design_Patterns.Pirates.TemplateMethod;
using Behavioral_Design_Patterns.Pirates.Visitor;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("-----------------Command Pattern-----------------");

        // Створення піратського корабля та капітана
        PirateShip pirateShip = new PirateShip();
        Captain captain = new Captain();

        // Надання команди на напад
        ICommand attackCommand = new AttackCommand(pirateShip);
        captain.SetCommand(attackCommand);
        captain.ExecuteCommand();

        // Надання команди на зміну курсу
        ICommand changeCourseCommand = new ChangeCourseCommand(pirateShip, "north");
        captain.SetCommand(changeCourseCommand);
        captain.ExecuteCommand();

        Console.WriteLine("\n-----------------Chain_of_Responsibility-----------------");
        // Створюємо обробників
        IPirateHandler captainHandler = new CaptainHandler(); //Ship Maneuver
        IPirateHandler quartermaster = new QuartermasterHandler(); //Nautical Charts
        IPirateHandler mechanic = new MechanicHandler(); //Repairs
        IPirateHandler doctor = new DoctorHandler(); //Medical
        IPirateHandler cook = new CookHandler(); //Food

        // Налаштовуємо ланцюг відповідальності
        captainHandler.SetNextHandler(quartermaster);
        quartermaster.SetNextHandler(mechanic);
        mechanic.SetNextHandler(doctor);
        doctor.SetNextHandler(cook);
        
        // Створюємо запити
        var ShipManeuverRequest = new Request("Ship Maneuver");
        var NauticalChartsRequest = new Request("Nautical Charts");
        var repairRequest = new Request("Repairs");
        var medicalRequest = new Request("Medical");
        var foodRequest = new Request("Food");
        var entertainmentRequest = new Request("Entertainment");

        // Викликаємо обробники для запитів
        captainHandler.HandleRequest(ShipManeuverRequest);
        Console.WriteLine("----------------------");
        captainHandler.HandleRequest(NauticalChartsRequest);
        Console.WriteLine("----------------------");
        captainHandler.HandleRequest(repairRequest);
        Console.WriteLine("----------------------");
        captainHandler.HandleRequest(medicalRequest);
        Console.WriteLine("----------------------");
        captainHandler.HandleRequest(foodRequest);
        Console.WriteLine("----------------------");
        captainHandler.HandleRequest(entertainmentRequest);
        Console.WriteLine("----------------------");

        Console.WriteLine("\n-----------------Iterator-----------------");
        // Створення колекції піратських портів
        PiratePortCollection portCollection = new PiratePortCollection();
        portCollection.AddPort(new PiratePort("Tortuga", "Caribbean"));
        portCollection.AddPort(new PiratePort("Nassau", "Bahamas"));
        portCollection.AddPort(new PiratePort("Port Royal", "Jamaica"));

        // Перегляд портів за допомогою ітератора
        Console.WriteLine("Pirate Ports:");
        foreach (var port in portCollection)
        {
            Console.WriteLine($"{port.Name} - Location: {port.Location}");
        }

        Console.WriteLine("\n-----------------Mediator-----------------");

        // Створення посередника (медіатора) - капітана корабля
        ShipMediator mediator = new ShipMediator();

        // Створення членів екіпажу (піратів)
        Pirate jack = new Pirate("Jack", mediator);
        Pirate anne = new Pirate("Anne", mediator);
        Pirate will = new Pirate("Will", mediator);

        // Відправлення повідомлень між членами екіпажу через посередника
        jack.Send("Anne", "Hey Anne, what's up?");
        anne.Send("Jack", "Not much, just swabbing the deck.");
        will.Send("Anne", "Captain wants us all on deck!");

        // Відправлення загального повідомлення всьому екіпажу через посередника
        mediator.BroadcastMessage("All hands on deck, prepare to set sail!");

        // Отримання загального повідомлення всіма членами екіпажу через посередника
        jack.ReceiveBroadcast("Get ready to sail!");
        anne.ReceiveBroadcast("Aye, aye, captain!");
        will.ReceiveBroadcast("I'm on my way!");

        Console.WriteLine("\n-----------------Memento-----------------");
        // Створення об'єктів
        TreasureOriginator originator = new TreasureOriginator("Forest");
        TreasureCaretaker caretaker = new TreasureCaretaker();

        // Додаємо початковий момент шляху до скарбу
        caretaker.AddMemento(originator.CreateMemento());

        // Міняємо розташування скарбу та зберігаємо новий момент шляху
        originator.SetMemento(new TreasureMemento("River"));
        caretaker.AddMemento(originator.CreateMemento());

        // Міняємо розташування скарбу знову та зберігаємо новий момент шляху
        originator.SetMemento(new TreasureMemento("Mountain"));
        caretaker.AddMemento(originator.CreateMemento());

        // Відновлення шляху до скарбу
        Console.WriteLine("Шлях до скарбу:");
        for (int i = 0; i < caretaker.mementoList.Count; i++)
        {
            Console.WriteLine(caretaker.GetMemento(i).Location);
        }

        Console.WriteLine("\n-----------------Observer-----------------");
        // Створюємо спостережувану станцію погоди
        WeatherStation weatherStation = new WeatherStation();

        // Створюємо спостерігача
        PirateObserver pirateObserver1 = new PirateObserver();
        // Підписуємо спостерігача на спостереження за погодою
        weatherStation.RegisterObserver(pirateObserver1);

        PirateObserver pirateObserver2 = new PirateObserver();
        weatherStation.RegisterObserver(pirateObserver2);

        WeatherData updatedWeatherData = new WeatherData
        {
            Temperature = 25.0f,
            WindDirection = "East",
            Precipitation = "Sunny",
            Cloudiness = 0.3f
        };

        // Встановлюємо нові дані про погоду на спостережуваній станції
        weatherStation.SetMeasurements(updatedWeatherData);

        // Видаляємо першого піратського спостерігача зі списку спостережувачів
        weatherStation.RemoveObserver(pirateObserver1);

        WeatherData anotherWeatherData = new WeatherData
        {
            Temperature = 20.0f,
            WindDirection = "South",
            Precipitation = "Rainy",
            Cloudiness = 0.9f
        };
        weatherStation.SetMeasurements(anotherWeatherData);

        Console.WriteLine("\n-----------------State-----------------");
        // Створення корабля
        Ship ship = new Ship();
        
        // Перевірка стану корабля під час плавання
        Console.WriteLine("Ship is in Floating state:");
        ship.Move();
        ship.Attack();
        ship.Repair();
        ship.UnloadCargo();

        ship.SetState(new BattleState()); // Зміна стану на бойовий

        // Перевірка стану корабля під час бою
        Console.WriteLine("\nShip is in Battle state:");
        ship.Move();
        ship.Attack();
        ship.Repair();
        ship.UnloadCargo();

        ship.SetState(new MooredState()); // Зміна стану на причалений

        // Перевірка стану корабля під час причалення
        Console.WriteLine("\nShip is in Moored state:");
        ship.Move();
        ship.Attack();
        ship.Repair();
        ship.UnloadCargo();

        ship.SetState(new UnderRepairState()); // Зміна стану на стан ремонту

        // Перевірка стану корабля під час ремонту
        Console.WriteLine("\nShip is in Under Repair state:");
        ship.Move();
        ship.Attack();
        ship.Repair();
        ship.UnloadCargo();

        Console.WriteLine("\n-----------------Strategy-----------------");
        PirateCaptain pirateCaptain = new PirateCaptain();

        pirateCaptain.SetCombatStrategy(new HitAndRunStrategy());
        pirateCaptain.ExecuteCombatStrategy();

        pirateCaptain.SetCombatStrategy(new MassiveAttackStrategy());
        pirateCaptain.ExecuteCombatStrategy();

        pirateCaptain.SetCombatStrategy(new StealthStrategy());
        pirateCaptain.ExecuteCombatStrategy();

        Console.WriteLine("\n-----------------Template Method-----------------");
        Console.WriteLine("\nBuilding a Brig:");
        ShipBuilder brigBuilder = new BrigBuilder();
        brigBuilder.BuildShip();

        Console.WriteLine("\nBuilding a Frigate:");
        ShipBuilder frigateBuilder = new FrigateBuilder();
        frigateBuilder.BuildShip();

        Console.WriteLine("\nBuilding a Galleon:");
        ShipBuilder galleonBuilder = new GalleonBuilder();
        galleonBuilder.BuildShip();

        Console.WriteLine("\n-----------------Visitor-----------------");
        // Створення елементів інвентаря з різними даними
        Weapon sword = new Weapon(new List<string> { "Cutlass", "Saber", "Pistol" });
        Food food = new Food(new List<string> { "Salted fish", "Dried meat", "Biscuits" });
        Drink drink = new Drink(new List<string> { "Rum", "Brandy", "Wine" });
        Treasure treasure = new Treasure(new List<string> { "Gold coins", "Silver coins", "Jewelry", "Gemstones" });

        // Створення екземпляра відвідувача
        InventoryPrinter inventoryPrinter = new InventoryPrinter();


        // Виклик методу Accept для кожного елементу інвентаря
        sword.Accept(inventoryPrinter);
        food.Accept(inventoryPrinter);
        drink.Accept(inventoryPrinter);
        treasure.Accept(inventoryPrinter);
    }
}