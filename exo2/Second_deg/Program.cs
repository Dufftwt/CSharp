        Console.WriteLine("Choisissez le type d'équation à résoudre :");
        Console.WriteLine("1. Premier degré (ax + b = 0)");
        Console.WriteLine("2. Second degré (ax^2 + bx + c = 0)");
        string choix = Console.ReadLine();

        if (choix == "1")
        {
            Console.Write("Entrez la valeur de a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la valeur de b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("L'équation n'a pas de solution.");
            }
            else
            {
                double solution = -b / a;
                Console.WriteLine("La solution de l'équation est : " + solution);
            }
        }
        else if (choix == "2")
        {
            // Code pour l'équation du second degré
						Console.Write("Entrez la valeur de a:");
						double a = Convert.ToDouble(Console.ReadLine());

						Console.Write("Entrez la valeur de b:");
						double b = Convert.ToDouble(Console.ReadLine());

						Console.Write("Entrez la valeur de c:");
						double c = Convert.ToDouble(Console.ReadLine());

						double discriminant = b * b - 4 * a * c;

						if (discriminant > 0)
						{
								double racine1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
								double racine2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
								Console.WriteLine("Les solutions de l'équation sont : " + racine1 + " et " + racine2);
						}
						else if (discriminant == 0)
						{
								double racine = -b / (2 * a);
								Console.WriteLine("L'équation a une solution double : " + racine);
						}
						else
						{
								Console.WriteLine("L'équation n'a pas de solutions réelles.");
						}
        }
        else
        {
            Console.WriteLine("Choix invalide.");
        }