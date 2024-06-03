using MauiGallery.Models;
using MauiGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component> {
                    new Component {
                        Title = "StackLayout",
                        Description="Organização sequencial dos elementos",
                        Page = typeof(StackLayoutPage)

                        //Page = new StackLayoutPage() //TODO - Performance - Evitar de instanciar páginas em lista. Aumenta muito a memória.
                    },
                    new Component
                    { 
                        Title = "Grid",
                        Description="Organiza os elementos dentro de uma tabela.",
                        Page = typeof(GridLayoutPage)
                    }, 
                    new Component 
                    {
                        Title = "AbsoluteLayout",
                        Description="Libertade total para posicionar e dimensionar os elementos na tela.",
                        Page = typeof(AbsoluteLayoutPage)
                    }
                }
            });

            return categories;
        }
    }
}
