using Structural_Design_Patterns.Forge_of_heroes.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_Design_Patterns.Forge_of_heroes.Flyweight
{
    public class MaterialFactory
    {
        //створення словника матеріалів та якщо матеріал з вказаним ключем вже існує у словнику, він повертається без створення нового.
        //якщо матеріал відсутній він створюється відповідно до ключа і додається до словника, а потім повертається. 

        private Dictionary<string, MaterialComponent> material = new Dictionary<string, MaterialComponent>();

        public MaterialComponent GetMaterial(string key, double weight) {
            if(!material.ContainsKey(key)) {
                // створення нового матеріалу лише в разі його відсутності
                switch(key)
                {
                    case "Iron":
                    case "Steel":
                        material[key] = new Metal(key, weight);
                        break;
                    case "Oak":
                        material[key] = new Wood(key, weight);
                        break;
                    case "Ruby":
                    case "Diamond":
                        material[key] = new Gemstone(key, weight);
                        break;
                }
            }
            return material[key];
        }
    }
}
