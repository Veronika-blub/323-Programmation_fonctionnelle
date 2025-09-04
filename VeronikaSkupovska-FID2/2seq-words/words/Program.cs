using System.Text.RegularExpressions;

// Partie 1 : Recherche par critère

//A. Filtrage basique-------------

string[] words = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune" };

Func<string, bool> NoX = word => word.Contains("x");
Func<string, bool> moreThanFour = word => word.Length >= 4;
Func<string, bool> avgLength =
word => word.Length == words.Average(word1 => word1.Length);

void Menu( IEnumerable<string> words)
{

    Console.WriteLine("choisir quel filtre appliquer: \n (1) longueur >= 4, \n(2) ne contient pas x, \n(3) longueur = moyenne");
    int filtre;
    int.TryParse(Console.ReadLine(), out filtre);
    switch (filtre)
    {
        case 1:
            Console.WriteLine("ont une longueur supérieure ou égale à 4");
            Console.WriteLine(String.Join(", ", words.Where(moreThanFour)));
            break;
        case 2:
            Console.WriteLine("ne contiennent pas la lettre x");

            Console.WriteLine(String.Join(", ", words.Where(NoX)));
            break;
        case 3:
            Console.WriteLine("ont une longueur égale à la moyenne");
            Console.WriteLine(String.Join(", ", words.Where(avgLength)));
            break;
        default:
            Console.WriteLine("Filtre non reconnu");
            break;
    }

    Console.WriteLine("options d’affichage:\n(1) dans l’ordre inverse de celui naturellement calculé, \n(2)triés a-z, \n(3)triés z-a");
    int options;
    int.TryParse(Console.ReadLine(), out options);
    switch (options)
    {
        case 1:
            Console.WriteLine("dans l’ordre inverse de celui naturellement calculé");
            Console.WriteLine(String.Join(", ", words.Reverse()));
            break;
        case 2:
            Console.WriteLine("triés a-z");
            Console.WriteLine(String.Join(", ", words.OrderBy(word => word)));
            break;
        case 3:
            Console.WriteLine("triés z-a");
            Console.WriteLine(String.Join(", ", words.OrderByDescending(word => word)));
            break;
        default:
            Console.WriteLine("Option non reconnue");
            break;
    }
}

//Menu(words);

//B. Données parasites 1-------------

string[] wordsB = { "whatThe!!!", "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "My kingdom for a horse !", "Ooops I did it again" };

var filteredWordsB = wordsB
    .Where((word, idx) => idx != 0 && idx != wordsB.Length - 1 && idx != wordsB.Length - 2)
    .ToArray();
//Console.WriteLine(String.Join(", ", filteredWordsB));

//C. Données parasites 2--------------
string[] wordsC = { "+++++", "<<<<<", ">>>>>", "bonjour", "hello", "@@@@", "vert", "rouge", "bleu", "jaune", "#####", "%%%%%%%" };

Func<string, bool> noSymb = word => Regex.IsMatch(word, "^[a-zA-Z]+$");
var filteredWordsC = wordsC.Where(noSymb).ToArray();
Console.WriteLine(String.Join(", ", filteredWordsC)); 

//D. Élitisme-------------
string[] wordsD = { "i am the winner", "hello", "monde", "vert", "rouge", "bleu", "i am the looser" };

var winner = wordsD.First();
var looser = wordsD.Last();
Console.WriteLine($"The winner is : {winner}\nThe looser is : {looser}");

//Partie 2: Epsilon
char[] lettre = { 'e', 'a', 'i', 's', 'n', 'r', 't', 'o', 'l', 'u',
'd', 'c', 'm', 'p', 'é', 'g', 'b', 'v', 'h', 'f',
'q', 'y', 'x', 'j', 'è', 'à', 'k', 'w', 'z', 'ê',
'ç', 'ô', 'â', 'î', 'û', 'ù', 'ï', 'á', 'ü', 'ë',
'ö', 'í' };




