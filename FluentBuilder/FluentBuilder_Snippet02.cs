var pizzaiolo = new PizzaBuilder();

var margherita = pizzaiolo.CreatePizzaWithSize(Size.Medium)
						.WithCrust(Crusts.Thin)
						.WithSauce(Sauces.Tomato)
						.AddTopping(Toppings.Mozzarella)
						.AddTopping(Toppings.Basil)
						.Bake();