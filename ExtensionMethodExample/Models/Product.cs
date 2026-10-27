using ExtensionMethodExample.Interfaces;

namespace ExtensionMethodExample.Models
{
    public class Product : IDisplayable
    {
        public int ProductId { get; set; }
        public string? Description { get; set; }

        public string GetDisplayText()
        {
            return $"{ProductId} {Description}";
            ;
        }
    }
}
