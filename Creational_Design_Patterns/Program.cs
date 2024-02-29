using Pizzeria.Builder_Pattern;
using Pizzeria.Factory_Pattern;
using Pizzeria.Factory_Pattern__Abstract_Factory_Pattern;
using Pizzeria;

internal class Program
{
    public static void Main(string[] args)
    {
        // Використання Singleton Pattern для печі
        Oven oven = Oven.getInstance();
        // Використання Factory Pattern для створення інгредієнтів
        PizzaIngredientFactory pizzaIngredient = new PizzaIngredientFactory();
        Console.WriteLine("_____________________Pizza Ingredient Factory_____________________");

        IPizzaIngredientFactory pepperoni = pizzaIngredient.getPizzaFactory("Pepperoni Pizza");
        Console.WriteLine($"Pepperoni Pizza:\n {pepperoni.PrintPizzaIngredient()}");

        IPizzaIngredientFactory classic = pizzaIngredient.getPizzaFactory("Classic Pizza");
        Console.WriteLine($"Classic Pizza:\n {classic.PrintPizzaIngredient()}");

        PizzaFactory pizzaFactory = new PizzaFactory();

        Console.WriteLine("_____________________Pizza Factory_____________________");
        // Замовлення пепероні піци
        Pizza pepperoniPizza = pizzaFactory.CreatePizza("Pepperoni Pizza");
        if (pepperoniPizza != null)
        {
            Console.WriteLine(pepperoniPizza.PrintPizza());
        }

        // Замовлення класичної піци
        Pizza capricciosa = pizzaFactory.CreatePizza("Capricciosa Pizza");
        if (capricciosa != null)
        {
            Console.WriteLine(capricciosa.PrintPizza());
        }

        Console.WriteLine("_____________________Builder Pattern_____________________");
        PizzaMenu menu = new PizzaMenu();
        // вивід меню
        Console.WriteLine("\n********** Menu **********\n");
        foreach (var pizzaItem in menu.MenuItems)
        {
            Pizza pizza = pizzaFactory.CreatePizza(pizzaItem.Name);
            if (pizza != null)
            {
                Console.WriteLine($"{pizza.PrintPizza()} \nPrice: {pizzaItem.Price}\n");
            }
        }
        Console.WriteLine("\n**************************\n");

        OrderBuilder builder = new OrderBuilder();
        Order order = builder.AddPizza(menu.MenuItems[0]) // Додаємо першу піцу з меню до замовлення
                             .AddPizza(menu.MenuItems[2]) // Додаємо другу піцу з меню до замовлення
                             .Build(); // Побудова замовлення

        // Виведення деталей замовлення та загальної суми
        Console.WriteLine("Ordered Items:");
        foreach (var item in order.OrderedItems)
        {
            Console.WriteLine($"{item.Name} - {item.Price} ГРН");
        }
        Console.WriteLine($"Total: {order.CalculateTotal()} ГРН");

        Console.WriteLine("\n_____________________Prototype Pattern_____________________\n");
        Pizza clonedPizza_1 = (Pizza)pepperoniPizza.Clone();
        Console.WriteLine(clonedPizza_1.PrintPizza());
        Pizza clonedPizza_2 = (Pizza)capricciosa.Clone();
        Console.WriteLine(clonedPizza_2.PrintPizza());
    }
}