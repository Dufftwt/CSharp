Console.WriteLine("Calculatrice en C# (METTRE DES ESPACES ENTRE LES CHIFFRES ET LES OPÉRATEURS)");
Console.WriteLine("Entrez un simple calcul (ex: 5 + 3): ");

string input = Console.ReadLine(); 
string[] parts = input.Split(' '); 

double a = double.Parse(parts[0]); 
double b = double.Parse(parts[2]); 

double result = 0;

switch (parts[1]) 
{
		case "+":
				result = a + b;
				break;
		case "-":
				result = a - b;
				break;
		case "*":
				result = a * b;
				break;
		case "/":
				result = a / b;
				break;
		default:
				Console.WriteLine("Opérateur inconnu");
				return;
}

Console.WriteLine("Résultat: " + result);