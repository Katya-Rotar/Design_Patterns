using Structural_Design_Patterns.Forge_of_heroes;
using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using Structural_Design_Patterns.Forge_of_heroes.Facade;

public class Program
{
    public static void Main(string[] args)
    {
        IMaterialComponent materialComponent = new CompositeMaterial("Materials", 0);
        ForgeFacade facade = new ForgeFacade(materialComponent);
        Console.WriteLine("Creating a sword \n----------------------------------------\n");
        string nameSword_1 = "Dragonbane";
        List<MaterialComponent> MetalMaterialsDragonbane = new List<MaterialComponent>();
        MetalMaterialsDragonbane.Add(new Metal("Iron", 500));
        MetalMaterialsDragonbane.Add(new Metal("Steel", 150));
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

        //
        facade.ModifyItem("Dragonbane", 8, "Flaming Sword");//Палаючий меч
        facade.ModifyItem("Dragonbane", 28, "Energy Burst");//Вибух енергії

        facade.ModifyItem("Blade of Kings", 15, "Sharper Angles"); //Гострі кути
        facade.ModifyItem("Blade of Kings", 30, "Explosive Wave"); //Вибухова хвиля
        facade.ShowInventory();
    }
}