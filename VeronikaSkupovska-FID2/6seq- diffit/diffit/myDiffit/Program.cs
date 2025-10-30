//Auteur : Veronika Skupovska
//Date   : 09.10.2025 
//Lieu   : ETML
//Descr. : Donnée pour le test pratique 323
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace KillThoseDuplicatesDonnee
{
    class Program
    {
        // Le programme KTD sert à repérer les fichiers à double au sein d'une arborescence de dossiers.
        // Il permet ensuite d'agir sur les doublons:
        //   - Soit il se contente de les signaler et de proposer des actions
        //   - Soit il efface les fichiers redondants pour ne garder que celui qui a été utilisé en dernier
        //
        // Pour pouvoir dire si deux fichiers sont  identiques ou pas, on se sert d'un discriminant, c'est-à-dire une valeur 
        // calculée qui est la même pour deux fichiers que l'on considère égaux
        //
        // KTD supporte trois manières de déterminer l'égalité de deux fichiers
        //   1. Deux fichiers sont égaux s'ils ont le même nom
        //      Exemple: 'C:\Temp\Readme.md' et 'C:\Temp\exo\Readme.md' sont considérés comme égaux
        //      parce qu'ils ont le même nom ('Readme.md').
        //
        //   2. Deux fichiers sont égaux s'ils ont le même nom ET la même taille
        //      Exemple: 'C:\Temp\Readme.md' et 'C:\Temp\exo\Readme.md' sont considérés comme différents
        //      parce que le premier fait 1265 bytes (discriminant: 'Readme.md-1265') et le deuxième en fait 975 (discriminant:
        //      'Readme.md-975')
        //
        //   3. Deux fichiers sont égaux s'ils ont le même nom, la même taille ET la même date de modification
        //      Exemple: 'C:\Temp\Readme.md' et 'C:\Temp\exo\Readme.md' sont considérés comme égaux parce qu'ils font
        //      la même taille (2319 bytes et ils ont tous les deux été modifiés (LastWriteTime)
        //      le 1er octobre 2024 (ils ont donc le même discriminant 'Readme.md-2319-2024-10-01')

        static void Main(string[] args)
        {
			// TODO #0A: (3pts) Faire un commit pour chaque todo 
			// TODO #0B: (3pts) Respecter les conventions de codage ETML (surtout en terme de nom de variable...)
			
			//Affiche l'aide si aucun paramètre n'est fourni
            if (args.Length == 0)
            {
                ShowHelp();
                return;
            }
            string path = args[0];
			//Initialisation par défaut
            string currentPath = Directory.GetCurrentDirectory();
            string extension = "";

            // TODO #1: (3pts) Remplacer les "lambda n'importe quoi" par quelque chose de correct
            Func<FileInfo, string> ByName = x => x.Name;
            Func<FileInfo, string> ByNameAndSize = x => $"{x.Name}-{x.Length}";
            Func<FileInfo, string> ByNameSizeAndDate = x => $"{x.Name}-{x.Length}-{x.LastWriteTime:yyyy-MM-dd}";

            // TODO #2: (3pts) Définir le critère par défaut (en se basant sur la démo ou en proposant un choix pertinent avec commentaire)
            Func<FileInfo, string> fileCriterion = x => ByName(x); // Par défaut, on considère que deux fichiers sont identiques s'ils ont le même nom


            // TODO #3: (3pts) Proposer un discriminant supplémentaire qui tiendrait compte du contenu du fichier
            // !!! Il suffit d'énoncer une proposition au moyen de commentaires !!! Pas besoin de l'implémenter
            //FileHash




            // TODO #4: (3pts) Remplacer les "lambda n'importe quoi" par quelque chose de correct et définir l'action par défaut
            Action<FileInfo> SuggestDelete = x => Console.WriteLine($"A effacer:{x.FullName}");
            Action<FileInfo> ExecuteDelete = x => { Console.WriteLine($"Effacement de:{x.FullName}"); File.Delete(x.FullName); };

            Action<FileInfo> fileAction = x => SuggestDelete(x); // Par défaut, on suggère les fichiers à effacer sans les effacer réellement


            //Traitement des arguments de la ligne de commande
            // TODO #5: (3pts) Remplacer tous les "lambda n'importe quoi" de ce bloc "for" par quelque chose de cohérent
            for (int a = 0; a < args.Length; a++)
            {
                if (args[a].StartsWith("-h"))
                {
                    ShowHelp();
                    return;
                }
                if (args[a].StartsWith("-d")) currentPath = args[a + 1];
                if (args[a].StartsWith("-e")) extension = "." + args[a + 1];
                if (args[a].StartsWith("-a"))
                {
                    if (args[a + 1] == "echo")
                        fileAction = x => SuggestDelete(x);
                    else if (args[a + 1] == "delete")
                        fileAction = x => ExecuteDelete(x);
                    else
                    {
                        ShowHelp();
                        return;
                    }
                }
                if (args[a].StartsWith("-c"))
                {
                    if (args[a + 1] == "size")
                        fileCriterion = x => ByNameAndSize(x);
                    else if (args[a + 1] == "date")
                        fileCriterion = x => ByNameSizeAndDate(x);
                    else
                    {
                        ShowHelp();
                        return;
                    }
                }
            }
            // TODO #6: (2pts) Afficher l'aide en cas d'erreur de paramètres (p.ex: -extension comme dernier paramètre ou en passant -extension sans indiquer l'extension)
            if (args[args.Length - 1].StartsWith("-e") || args[args.Length - 1].StartsWith("-d") || args[args.Length - 1].StartsWith("-a") || args[args.Length - 1].StartsWith("-c")) { ShowHelp(); return; };

            // TODO #7: (1pts) Terminer le programme si un dossier est donné mais n'existe pas
            if (!File.Exists(currentPath)) { System.Environment.Exit(1); } ;

            // TODO #8: (6pts) peupler la liste 'fileinfos' en vous aidant des éléments du dossier doc
            List<FileInfo> fileInfos = Directory.GetFiles(currentPath); // Liste de tous les fichiers dans le dossier choisi et tous ses sous-dossiers

            // TODO #9: (6pts) Si une extension a été donnée, ne garder que les fichiers qui correspondent

            // TODO #10: (9pts) Identifier les fichiers à double (ou plus) en passant par une structure <string,List<FileInfo>> où string est le discriminant (p.ex: 'Readme.md-123456')

            // TODO #11: (9pts) Traiter les duplicats avec l'action choisie

            Console.ReadKey();
        }

        static private void ShowHelp()
        {
            Console.WriteLine("KillThoseDuplicates (ktd) par VeronikaSkupovska:");
            Console.WriteLine(
                "Un utilitaire qui permet de gérer les fichiers en double dans une arborescence\n" +
                "\n" +
                "usage: ktd [-h[elp]] [-e[xtension] <ext>] [-d[irectory] <path>] [-a[ction] {echo|delete}] [-c[riterion] {size|date}]\n" +
                "\n" +
                "-d[irectory]:  s'applique au dossier <path>. Le répertoire courant s'il n'est pas spécifié\n" +
                "-e[xtension]:  ne s'applique qu'aux fichiers qui ont l'extension est <ext>\n" +
                "-c[riterion]:  size: considère deux fichiers identiques par nom ET taille\n" +
                "               date: considère deux fichiers identiques par nom, taille ET date de modification\n" +
                "-a[ction]:     echo: affiche les fichiers à effacer\n" +
                "               delete: effectue l'effacement des fichiers (et l'annonce)"
                );
            Console.ReadKey();
        }

        /*==================================================================================================================
         
        Aides:

        - La classe Program est statique. Les méthodes que vous déclarez doivent donc également être statiques

        - Pour connaître les attributs d'un objet de type FileInfo, faire F12 ou l'inspecter avec le debugger

        - Pour passer des arguments à votre programme pendant le développement dans Visual Studio:
            Menu Déboguer>Propriétés de débogage

		- Pour passer des arguments via la ligne de commande, on peut procéder ainsi (-- après run):
		  dotnet run -- -e txt -d data -a echo -c date

        - Appliqué à la structure de fichiers de test fournis (dossier ‘data’)
            - Sans préciser de critère: KTD agit sur les fichiers dans les trois répertoires 'copy','bigger' et 'older'
            - Avec '-criterion size': KTD n'agit que sur les fichiers de 'copy' et 'older' 
            - Avec '-criterion date': KTD n'agit que sur les fichiers de 'copy'
        ==================================================================================================================*/
    }
}
