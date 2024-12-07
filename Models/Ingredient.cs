namespace FoodBux_Restaurent.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }

        public string Name { get; set; }

        public ICollection<ProductIngredients> MyProperty { get; set; }
    }
}