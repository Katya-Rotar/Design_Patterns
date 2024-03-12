﻿using Structural_Design_Patterns.Forge_of_heroes.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Facade
{
    public class ForgeFacade
    {
        private Forge forge;

        public ForgeFacade() {
            this.forge = new Forge();
        }
        public void CreateItem(string nameSword, List<MaterialComponent> metal, List<MaterialComponent> wood, List<MaterialComponent> gemstone)
        {
            forge.Craft(nameSword, metal, wood, gemstone);
        }
        public void ModifyItem() {
            forge.Modify();
        }
        public void ShowInventory() {
            forge.DisplayInventory();
        }
    }
}
