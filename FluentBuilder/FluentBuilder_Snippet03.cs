public class PizzaBuilder : IPizzaBuilderCrust, IPizzaBuilderSauce, IPizzaBuilderToppings
{
	private readonly Pizza pizza;

	public PizzaBuilder()
	{
		pizza = new Pizza();
	}

	public PizzaBuilder CreatePizzaWithSize(Size selectedSize)
	{
		pizza.Size = selectedSize;
		return this;
	}
	
	...
	
	public Pizza Bake()
	{
		return pizza;
	}
}