using Structural_Design_Patterns.Forge_of_heroes.Adapter;
using Structural_Design_Patterns.Forge_of_heroes.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes
{
    public class Forge
    {
        private List<Sword> inventory;
        private IWeightAdapter weightAdapter;

        public Forge() {
            inventory = new List<Sword>();
            weightAdapter = new WeightAdapter();
        }
        public void Craft(string nameSword, List<MaterialComponent> MetalMaterials = null, List<MaterialComponent> WoodMaterials = null, List<MaterialComponent> GemstoneMaterials = null)
        {
            CompositeMaterial material = new CompositeMaterial("Materials", 0);

            if (MetalMaterials != null)
            {
                CompositeMaterial metals = new CompositeMaterial("Metals", 0);
                foreach (MaterialComponent materials in MetalMaterials)
                {
                    metals.Add(materials);
                }
                material.Add(metals);
            }

            if (WoodMaterials != null)
            {
                CompositeMaterial woods = new CompositeMaterial("Woods", 0);
                foreach (MaterialComponent materials in WoodMaterials)
                {
                    woods.Add(materials);
                }
                material.Add(woods);
            }

            if (GemstoneMaterials != null)
            {
                CompositeMaterial gemstones = new CompositeMaterial("Gemstones", 0);
                foreach (MaterialComponent materials in GemstoneMaterials)
                {
                    gemstones.Add(materials);
                }
                material.Add(gemstones);
            }


            Console.WriteLine($"{nameSword} successfully created!");
            Console.WriteLine("Used: ");
            material.Display(0);

            double totalWeight = material.GetTotalWeight();
            double kilogramsWeight = weightAdapter.ConvertGramsToKilograms(totalWeight);
            Console.WriteLine("Total weight of materials: " + kilogramsWeight + " kg\n");

            inventory.Add(new Sword(nameSword, kilogramsWeight, 10));
        }
        public void Modify() {
            // Логіка для модифікації предмету
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
