Console.Write("Donnez un nombre pour en afficher la table de multiplication: ");
if (!int.TryParse(Console.ReadLine(), out int number))
{
		Console.WriteLine("ERREUR: ce n'est pas un nombre entier ou le nombre est trop gros");
		return;
}

for (int i = 1; i <= 11; i++)
{
		Console.WriteLine(number + " * " + i + " = " + number * i);
}
