using Structural_Design_Patterns.Forge_of_heroes.Adapter;
using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using Structural_Design_Patterns.Forge_of_heroes.Decorator;
using Structural_Design_Patterns.Forge_of_heroes.Flyweight;

namespace Structural_Design_Patterns.Forge_of_heroes
{
    public class Forge
    {
        private List<Sword> inventory;
        private IWeightAdapter weightAdapter;
        private IMaterialComponent materialComponent;
        private MaterialFactory materialFactory;

        public Forge(IMaterialComponent materialComponent, MaterialFactory materialFactory) {
            inventory = new List<Sword>();
            weightAdapter = new WeightAdapter();
            this.materialComponent = materialComponent;
            this.materialFactory = materialFactory;
        }
        public void Craft(string nameSword, List<MaterialComponent>? MetalMaterials = null, List<MaterialComponent>? WoodMaterials = null, List<MaterialComponent>? GemstoneMaterials = null)
        {
            materialComponent = new CompositeMaterial("Materials", 0);

            if (MetalMaterials != null)
            {
                IMaterialComponent metals = new CompositeMaterial("Metals", 0);
                foreach (MaterialComponent materials in MetalMaterials)
                {
                    //Flyweight
                    // для кожного матеріалу у списку MetalMaterials використовується фабрика, щоб отримати відповідний екземпляр матеріалу за його назвою
                    var material = materialFactory.GetMaterial(materials.name, materials.weight);
                    metals.Add(material);
                }
                materialComponent.Add((MaterialComponent)metals);
            }

            if (WoodMaterials != null)
            {
                IMaterialComponent woods = new CompositeMaterial("Woods", 0);
                foreach (MaterialComponent materials in WoodMaterials)
                {
                    //Flyweight
                    var material = materialFactory.GetMaterial(materials.name, materials.weight);
                    woods.Add(material);
                }
                materialComponent.Add((MaterialComponent)woods);
            }

            if (GemstoneMaterials != null)
            {
                IMaterialComponent gemstones = new CompositeMaterial("Gemstones", 0);
                foreach (MaterialComponent materials in GemstoneMaterials)
                {
                    //Flyweight
                    var material = materialFactory.GetMaterial(materials.name, materials.weight);
                    gemstones.Add(material);
                }
                materialComponent.Add((MaterialComponent)gemstones);
            }


            Console.WriteLine($"{nameSword} successfully created!");
            Console.WriteLine("Used: ");
            materialComponent.Display(0);

            double totalWeight = materialComponent.GetTotalWeight();
            double kilogramsWeight = weightAdapter.ConvertGramsToKilograms(totalWeight);
            Console.WriteLine("Total weight of materials: " + kilogramsWeight + " kg\n");

            inventory.Add(new Sword(nameSword, kilogramsWeight, 10));
        }
        public void Modify(string swordName, int attackBonus, string featureName)
        {
            
            bool found = false;
            foreach (var sword in inventory)
            {
                if (sword.Name == swordName)
                {
                    found = true; // меч знайдено
                    ISwordDecorator decoratedSword = new SwordDecorator(sword);
                    int totalAttack = decoratedSword.AddFeature(attackBonus, featureName);
                    sword.Attack = totalAttack;
                    Console.WriteLine($"Modified sword {swordName} successfully!");
                }
            }
            if (!found)
            {
                Console.WriteLine($"Sword {swordName} not found!"); // виводимо повідомлення, якщо меч не знайдено
            }
        }
        public void DisplayInventory() {
            Console.WriteLine("\nInventory:");
            int id = 1;
            Console.WriteLine("----------------------------");
            foreach (var item in inventory)
            {
                Console.WriteLine($"{id}) {item}");
                Console.WriteLine("----------------------------");
                id++;
            }
        }
    }
}
