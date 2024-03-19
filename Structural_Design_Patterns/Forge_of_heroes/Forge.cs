using Structural_Design_Patterns.Forge_of_heroes.Adapter;
using Structural_Design_Patterns.Forge_of_heroes.Bridge;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using Structural_Design_Patterns.Forge_of_heroes.Decorator;

namespace Structural_Design_Patterns.Forge_of_heroes
{
    public class Forge
    {
        private List<Sword> inventory;
        private IWeightAdapter weightAdapter;
        private IMaterialComponent materialComponent;

        public Forge(IMaterialComponent materialComponent) {
            inventory = new List<Sword>();
            weightAdapter = new WeightAdapter();
            this.materialComponent = materialComponent;
        }
        public void Craft(string nameSword, List<MaterialComponent>? MetalMaterials = null, List<MaterialComponent>? WoodMaterials = null, List<MaterialComponent>? GemstoneMaterials = null)
        {
            materialComponent = new CompositeMaterial("Materials", 0);

            if (MetalMaterials != null)
            {
                IMaterialComponent metals = new CompositeMaterial("Metals", 0);
                foreach (MaterialComponent materials in MetalMaterials)
                {
                    metals.Add(materials);
                }
                materialComponent.Add((MaterialComponent)metals);
            }

            if (WoodMaterials != null)
            {
                IMaterialComponent woods = new CompositeMaterial("Woods", 0);
                foreach (MaterialComponent materials in WoodMaterials)
                {
                    woods.Add(materials);
                }
                materialComponent.Add((MaterialComponent)woods);
            }

            if (GemstoneMaterials != null)
            {
                IMaterialComponent gemstones = new CompositeMaterial("Gemstones", 0);
                foreach (MaterialComponent materials in GemstoneMaterials)
                {
                    gemstones.Add(materials);
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
        public void Modify(string swordName, int attackBonus, string featureName) {
            foreach (var sword in inventory)
            {
                if (sword.Name == swordName)
                {
                    ISwordDecorator decoratedSword = new SwordDecorator(sword);
                    int totalAttack = decoratedSword.AddFeature(attackBonus, featureName);
                    sword.Attack = totalAttack;
                    Console.WriteLine($"Modified sword {swordName} successfully!");
                }
            }
            Console.WriteLine($"Sword {swordName} not found!");
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
