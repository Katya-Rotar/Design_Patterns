using Behavioral_Design_Patterns.Pirates.Chain_of_Responsibility;
using Behavioral_Design_Patterns.Pirates.Command_Pattern;
using Behavioral_Design_Patterns.Pirates.Iterator;
using Behavioral_Design_Patterns.Pirates.Mediator;
using Behavioral_Design_Patterns.Pirates.Memento;

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
    }
}