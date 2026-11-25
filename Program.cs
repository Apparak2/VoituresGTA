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
        
        //Declare variable to have global access
        string errorMess = "";
        int nbCar;
        
        string[] cars = { "Banshee", "Zentorno", "Sultan", "Sanchez", "Buzzard" };
        DisplayCarsContent(cars);

        //While user's tapped index is out of bounds, re-ask the index
        do {
            Console.WriteLine("Quelle voiture voulez-vous remplacer ? (1 à 5)");
            nbCar = Convert.ToInt32(Console.ReadLine());
            errorMess = (!(nbCar >= 1 && nbCar <= 5)) ? "Ce n'est pas une valeur valide !" : "";
            DisplayErrorMess(errorMess);
        }
        while (errorMess != "");
        string newCar;

        //While user's tapped new car is in the array, re-ask the car
        do
        {
            Console.WriteLine("Quel est le nom du nouveau véhicule ?");
            newCar = Console.ReadLine();
            errorMess = (System.Array.IndexOf(cars, newCar) != -1) ? "Ce véhicule existe déjà !" : "";
            DisplayErrorMess(errorMess);
        }
        while (errorMess != "");
        
        //if newCar is null, affect empty string
        cars[nbCar - 1] = newCar ?? "";

        DisplayCarsContent(cars);
    }

    //Display each car of cars array
    static void DisplayCarsContent(string[] cars)
    {
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

    //Display error message if not empty
    static void DisplayErrorMess(string errorMess)
    {
        if(errorMess != "")
        {
            Console.WriteLine(errorMess);
        }
    }
}