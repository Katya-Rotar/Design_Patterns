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

        //техніки ковальської обробки
        IForge forge = new Forge();

        MetalworkingTechnique hotForging = new HotForging(forge);
        MetalworkingTechnique coldForging = new ColdForging(forge);
        MetalworkingTechnique designForging = new DesignForging(forge);

        // Створення мечів за допомогою патерна Builder
        Console.WriteLine("Dragonbane");
        string nameSword_1 = "Dragonbane";
        List<MaterialComponent> MetalMaterialsDragonbane = new List<MaterialComponent>();
        MetalMaterialsDragonbane.Add(new Metal("Iron", 150));
        MetalMaterialsDragonbane.Add(new Metal("Steel", 400));
        List<MaterialComponent> WoodMaterialsDragonbane = new List<MaterialComponent>();
        WoodMaterialsDragonbane.Add(new Wood("Oak", 200));
        List<MaterialComponent> GemstoneMaterialsDragonbane = new List<MaterialComponent>();
        GemstoneMaterialsDragonbane.Add(new Gemstone("Ruby", 10));

        hotForging.ProcessMetal();
        Console.ReadLine();

        facade.CreateItem(nameSword_1, MetalMaterialsDragonbane, WoodMaterialsDragonbane, GemstoneMaterialsDragonbane);

        //
        Console.WriteLine("Blade of Kings");
        string nameSword_2 = "Blade of Kings";
        List<MaterialComponent> MetalMaterialsBladeOfKings = new List<MaterialComponent>();
        MetalMaterialsBladeOfKings.Add(new Metal("Steel", 400));
        List<MaterialComponent> GemstoneMaterialsBladeOfKings = new List<MaterialComponent>();
        GemstoneMaterialsBladeOfKings.Add(new Gemstone("Diamond", 30));

        designForging.ProcessMetal();
        Console.ReadLine();

        facade.CreateItem(nameSword_2, MetalMaterialsBladeOfKings, null, GemstoneMaterialsBladeOfKings);

        //
        Console.WriteLine("Shadowslayer");
        string nameSword_3 = "Shadowslayer";
        List<MaterialComponent> MetalMaterialsShadowslayer = new List<MaterialComponent>();
        MetalMaterialsShadowslayer.Add(new Metal("Silver", 200));
        MetalMaterialsShadowslayer.Add(new Metal("Obsidian", 300));
        List<MaterialComponent> WoodMaterialsShadowslayer = new List<MaterialComponent>();
        WoodMaterialsShadowslayer.Add(new Wood("Ebony", 150));
        List<MaterialComponent> GemstoneMaterialsShadowslayer = new List<MaterialComponent>();
        GemstoneMaterialsShadowslayer.Add(new Gemstone("Amethyst", 15));

        coldForging.ProcessMetal();
        Console.ReadLine();

        facade.CreateItem(nameSword_3,MetalMaterialsShadowslayer, WoodMaterialsShadowslayer, GemstoneMaterialsShadowslayer);

        facade.ShowInventory();

        //Decorator
        IForgeProxy blacksmith = new BlacksmithProxy(facade);
        blacksmith.ModifyItem("Dragonbane", 8, "Flaming Sword");//Палаючий меч
        blacksmith.ModifyItem("Dragonbane", 28, "Energy Burst");//Вибух енергії

        IForgeProxy blacksmithAssistant = new BlacksmithAssistantProxy(facade);
        blacksmithAssistant.ModifyItem("Blade of Kings", 15, "Sharper Angles"); //Гострі кути
        blacksmithAssistant.ModifyItem("Blade of Kings", 30, "Explosive Wave"); //Вибухова хвиля

        // Виведення інвентаря за допомогою патерна Facade
        facade.ShowInventory();
    }
}