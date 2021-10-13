using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public static class TestData
    {
        public static void Init(ThemeContext context)
        {
            if (!context.Themes.Any())
            {
                context.Themes.AddRange(
                    new Theme
                    {
                        Title = "PC components",
                        Description = "Some new information about intel and amd"
                    },
                    new Theme
                    {
                        Title = "Android theme",
                        Description = "New android smartphones"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
