using Structural_Design_Patterns.Forge_of_heroes.Adapter;
using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using Structural_Design_Patterns.Forge_of_heroes.Decorator;
using Structural_Design_Patterns.Forge_of_heroes.Flyweight;

namespace Structural_Design_Patterns.Forge_of_heroes
{
    public class Forge : IForge
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

        public Forge()
        {
        }

        public void PrepareMaterials(List<MaterialComponent>? MetalMaterials, List<MaterialComponent>? WoodMaterials, List<MaterialComponent>? GemstoneMaterials)
        {
            materialComponent = new CompositeMaterial("Materials", 0);

            AddMaterialsToComponent(MetalMaterials, "Metals");
            AddMaterialsToComponent(WoodMaterials, "Woods");
            AddMaterialsToComponent(GemstoneMaterials, "Gemstones");
        }

        private void AddMaterialsToComponent(List<MaterialComponent>? materials, string componentName)
        {
            if (materials != null)
            {
                IMaterialComponent component = new CompositeMaterial(componentName, 0);
                foreach (MaterialComponent material in materials)
                {
                    var materialInstance = materialFactory.GetMaterial(material.name, material.weight);
                    component.Add(materialInstance);
                }
                materialComponent.Add((MaterialComponent)component);
            }
        }

        public void Craft(string nameSword, double kilogramsWeight)
        {
            Console.WriteLine($"{nameSword} successfully created!");
            Console.WriteLine("Used: ");
            materialComponent.Display(0);
            inventory.Add(new Sword(nameSword, kilogramsWeight, 10));
        }

        public double totalWeight() {
            double totalWeight = materialComponent.GetTotalWeight();
            double kilogramsWeight = weightAdapter.ConvertGramsToKilograms(totalWeight);
            Console.WriteLine("Total weight of materials: " + kilogramsWeight + " kg\n");
            return kilogramsWeight;
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

        public void HeatMetal()
        {
            Console.WriteLine("Heating the metal...");
        }

        public void BeatMetal()
        {
            Console.WriteLine("Beating the metal...");
        }

        public void BendMetal()
        {
            Console.WriteLine("Bending the metal...");
        }

        public void ShapeMetal()
        {
            Console.WriteLine("Shaping the metal...");
        }

        public void PreparePattern()
        {
            Console.WriteLine("Preparing the pattern...");
        }

        public void ApplyPattern()
        {
            Console.WriteLine("Applying the pattern...");
        }
    }
}
