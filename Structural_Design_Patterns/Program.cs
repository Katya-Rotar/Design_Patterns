using Structural_Design_Patterns.Forge_of_heroes;
using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using Structural_Design_Patterns.Forge_of_heroes.Facade;
using Structural_Design_Patterns.Forge_of_heroes.Flyweight;
using Structural_Design_Patterns.Forge_of_heroes.Proxy;

public class Program
{
    public static void Main(string[] args)
    {
        IMaterialComponent materialComponent = new CompositeMaterial("Materials", 0);
        MaterialFactory materialFactory = new MaterialFactory();
        ForgeFacade facade = new ForgeFacade(materialComponent, materialFactory);
        Console.WriteLine("Creating a sword \n----------------------------------------\n");

        // Створення мечів за допомогою патерна Builder
        string nameSword_1 = "Dragonbane";
        List<MaterialComponent> MetalMaterialsDragonbane = new List<MaterialComponent>();
        MetalMaterialsDragonbane.Add(new Metal("Iron", 150));
        MetalMaterialsDragonbane.Add(new Metal("Steel", 400));
        List<MaterialComponent> WoodMaterialsDragonbane = new List<MaterialComponent>();
        WoodMaterialsDragonbane.Add(new Wood("Oak", 200));
        List<MaterialComponent> GemstoneMaterialsDragonbane = new List<MaterialComponent>();
        GemstoneMaterialsDragonbane.Add(new Gemstone("Ruby", 10));
        facade.CreateItem(nameSword_1, MetalMaterialsDragonbane, WoodMaterialsDragonbane, GemstoneMaterialsDragonbane);

        string nameSword_2 = "Blade of Kings";
        List<MaterialComponent> MetalMaterialsBladeOfKings = new List<MaterialComponent>();
        MetalMaterialsBladeOfKings.Add(new Metal("Steel", 400));
        List<MaterialComponent> GemstoneMaterialsBladeOfKings = new List<MaterialComponent>();
        GemstoneMaterialsBladeOfKings.Add(new Gemstone("Diamond", 30));
        facade.CreateItem(nameSword_2, MetalMaterialsBladeOfKings, null, GemstoneMaterialsBladeOfKings);
        facade.ShowInventory();

        // Створення проксі-об'єктів для керування доступом до функціоналу ковальні за допомогою патерна Proxy
        bool userHasPermission;
        userHasPermission = true;

        //Decorator
        ForgeProxy forgeProxy_true = new ForgeProxy(facade, userHasPermission);
        forgeProxy_true.ModifyItem("Dragonbane", 8, "Flaming Sword");//Палаючий меч
        forgeProxy_true.ModifyItem("Dragonbane", 28, "Energy Burst");//Вибух енергії

        userHasPermission = false;
        ForgeProxy forgeProxy_false = new ForgeProxy(facade, userHasPermission);
        forgeProxy_false.ModifyItem("Blade of Kings", 15, "Sharper Angles"); //Гострі кути
        forgeProxy_false.ModifyItem("Blade of Kings", 30, "Explosive Wave"); //Вибухова хвиля

        // Виведення інвентаря за допомогою патерна Facade
        facade.ShowInventory();
    }
}