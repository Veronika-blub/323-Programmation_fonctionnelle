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
//Trouver une source fiable sur la répartition des lettres en français (A:8.15%, B:0.97%,...) et afficher les mots avec leur valeur Epsilon et uniquement ceux dont la valeur Epsilon est comprise entre 0.5 et 0.95.
string[] words2 = { "bonjour", "hello", "monde", "vert", "rouge", "bleu", "jaune", "ee" };
var frequencies = new Dictionary<char, double>
{
    { 'e', 12.10 },
    { 'a', 7.11 },
    { 'i', 6.59 },
    { 's', 6.51 },
    { 'n', 6.39 },
    { 'r', 6.07 },
    { 't', 5.92 },
    { 'o', 5.02 },
    { 'l', 4.96 },
    { 'u', 4.49 },
    { 'd', 3.67 },
    { 'c', 3.18 },
    { 'm', 2.62 },
    { 'p', 2.49 },
    { 'é', 1.94 },
    { 'g', 1.23 },
    { 'b', 1.14 },
    { 'v', 1.11 },
    { 'h', 1.11 },
    { 'f', 1.11 },
    { 'q', 0.65 },
    { 'y', 0.46 },
    { 'x', 0.38 },
    { 'j', 0.34 },
    { 'è', 0.31 },
    { 'à', 0.31 },
    { 'k', 0.29 },
    { 'w', 0.17 },
    { 'z', 0.15 },
    { 'ê', 0.08 },
    { 'ç', 0.06 },
    { 'ô', 0.04 },
    { 'â', 0.03 },
    { 'î', 0.03 },
    { 'û', 0.02 },
    { 'ù', 0.02 },
    { 'ï', 0.01 },
    { 'á', 0.01 },
    { 'ü', 0.01 },
    { 'ë', 0.01 },
    { 'ö', 0.01 },
    { 'í', 0.01 }
};
// Func<string, double> Epsilon = word =>
// {
//     double epsilon = 0;
//     foreach (char c in word.ToLower())
//     {
//         if (frequencies.ContainsKey(c))
//         {
//             epsilon += frequencies[c];
//         }
//     }
//     return epsilon / word.Length; 
// };
// Console.WriteLine("1"+Epsilon(words[0]));

// Func<string[], string[]> DEpsilon = wordsArray =>
// {
//     return wordsArray.Where(word =>
//     {
//         double eps = Epsilon(word);
//         return eps >= 0.5 && eps <= 0.95;
//     }).ToArray();
// };

// var filteredWords = DEpsilon(words2);
// Console.WriteLine("tableau: "+String.Join(", ", DEpsilon(words2)));

double Epsilon (string word, Dictionary<char, double> frequencies)
{
    return word
        .GroupBy(c => c)
        .ToDictionary(group => group.Key, group => group.Count())
        .Where(c => frequencies.ContainsKey(c.Key))
        .Sum(c => frequencies[c.Key] / 100.0 / c.Value);
}

List<string> wordsFiltered = words2
    .Where(w =>
    {
        double e = Epsilon(w, frequencies);
        return e >= 0.5 && e <= 0.97;
    })
    .ToList();

wordsFiltered.ForEach(word => Console.WriteLine(word));

Console.WriteLine(wordsFiltered);
Console.ReadLine();





