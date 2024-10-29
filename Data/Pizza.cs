namespace BlazingPizza.Data;

public class Pizza
{
  public required int PizzaId { get; set; }

  public required string Name { get; set; }

  public required string Description { get; set; }

  public required decimal Price { get; set; }

  public required string ImageUrl { get; set; }

  public bool Vegetarian { get; set; }

  public bool Vegan { get; set; }
}