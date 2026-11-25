namespace VoituresGTA;
/*
    CONSIGNES
    1. Déclarer un tableau contenant cinq véhicules :
        - Banshee
        - Zentorno
        - Sultan
        - Sanchez
        - Buzzard
    2. Afficher tous les véhicules du garage avec une boucle for.
    3. Demander au joueur de saisir le numéro du véhicule qu'il souhaite remplacer (de 1 à 5).
    4. Demander le nom du nouveau véhicule.
    5. Remplacer l'ancien véhicule par le nouveau dans le tableau.
    6. Afficher le contenu actualisé du garage.
*/
class Program
{
    static void Main(string[] args)
    {
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        DisplayCarsContent(cars);
        Console.WriteLine("Quelle voiture voulez-vous remplacer ? (1 à 5)");
        int nbCar = Convert.ToInt32(Console.ReadLine());
        /* string errorMess = (nbCar >= 1 && nbCar <= 5) ? "Ce n'est pas une valeur valide !" : "";
        */
        Console.WriteLine("Quel est le nom du nouveau véhicule ?");
        string newCar = Console.ReadLine();
        cars[nbCar - 1] = newCar ?? "";

        DisplayCarsContent(cars);
    }
    static void DisplayCarsContent(string[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }
}