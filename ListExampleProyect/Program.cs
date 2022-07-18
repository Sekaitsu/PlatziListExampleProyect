// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//CLASE DE LISTAS


//se define la lista y su nombre se crea una instancia - new es una palabra clave que nos ayuda a generar una instancia


List<string> tacoShoppingList = new List<string>()

{
    "Cinco Tacos de Suadero",
    "Cuatro Tacos de Tripa",
    "Cinco Tacos de Pastor",
    "Cuatro Cocas",
    "Papas",
};


//tacoShoppingList.Add("Cinco Tacos de Suadero");
//tacoShoppingList.Add("Cuatro Tacos de Tripa");
//tacoShoppingList.Add("Cinco Tacos de Pastor");
//tacoShoppingList.Add("Cuatro Cocas");

tacoShoppingList.Remove(tacoShoppingList[3]);
tacoShoppingList.Remove("Cinco Tacos de Suadero");
tacoShoppingList.RemoveAt(1);


for (int i = 0; i < tacoShoppingList.Count; i++)
{
    Console.WriteLine("Compro "+ tacoShoppingList[i]);
}



