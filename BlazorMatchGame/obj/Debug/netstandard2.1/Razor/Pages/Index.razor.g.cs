#pragma checksum "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea11af2a0ce555d6aeaa4b7cd69e9457da8ccaa7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMatchGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/_Imports.razor"
using BlazorMatchGame.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\n    .container {\n        width: 400px;\n    }\n\n    button{\n        width: 100px;\n        height: 100px;\n        font-size: 50px;\n    }\n</style>\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 16 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
         for (var animalNumber = 0; animalNumber < shuffledAnimals.Count; animalNumber++)
         {
            var animal = shuffledAnimals[animalNumber];
            var uniqueDescription = $"Button #{animalNumber}";

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-3");
            __builder.AddMarkupContent(10, "\n                ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                                    () => ButtonClick(animal, uniqueDescription)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "btn btn-outline-dark");
            __builder.AddMarkupContent(15, "\n                    ");
            __builder.OpenElement(16, "h1");
            __builder.AddContent(17, 
#nullable restore
#line 23 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                         animal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n");
#nullable restore
#line 26 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "row");
            __builder.AddMarkupContent(25, "\n        ");
            __builder.OpenElement(26, "h2");
            __builder.AddContent(27, "Matches Found: ");
            __builder.AddContent(28, 
#nullable restore
#line 29 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
                            matchesFound

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "/Users/lulungei/Projects/BlazorMatchGame/BlazorMatchGame/Pages/Index.razor"
      
    //Creating a list to hold the emojis to match
    List<string> animalEmoji = new List<string>()
    {
        "🐶", "🐶",
        "🐺", "🐺",
        "🐮", "🐮",
        "🦊", "🦊",
        "🐯", "🐯",
        "🐱", "🐱",
        "🦁", "🦁",
        "🐹", "🐹",

    };

    List<string> shuffledAnimals = new List<string>();

    int matchesFound = 0;
    protected override void OnInitialized()
    {
        SetUpGame();
    }
    // This method shuffles the animals
    private void SetUpGame()
    {
        Random random = new Random();
        shuffledAnimals = animalEmoji
            .OrderBy(item => random.Next())
            .ToList();
        matchesFound = 0;

    }


    string lastAnimalFound = string.Empty;
    string lastDescription = string.Empty;

    private void ButtonClick(string animal, string animalDescription)
    {
        if (lastAnimalFound == string.Empty)
        {
            // First selection of the pair. Remember it
            lastAnimalFound = animal;
            lastDescription = animalDescription;
        }

        else if ((lastAnimalFound == animal) && (animalDescription != lastDescription))
        {
            // Match found. Reset for next pair
            lastAnimalFound = string.Empty;

            // Replace found animals with empty string to hide them.
            shuffledAnimals = shuffledAnimals
                .Select(a => a.Replace(animal, string.Empty))
                .ToList();

            matchesFound++;
            if(matchesFound == 8)
            {
                SetUpGame();
            }

        }
        else
        {
            // User selected a pair that don't match
            // Reset selection

            lastAnimalFound = string.Empty;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
