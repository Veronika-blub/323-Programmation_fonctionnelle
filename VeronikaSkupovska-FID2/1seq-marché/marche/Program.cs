// See https://aka.ms/new-console-template for more information
using System;

namespace marche
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Product { emplacement = 1, producer = "Bornand", name = "Pommes", quantity = 20,units = "kg", price = 5.50 },
            new Product { emplacement = 1, producer = "Bornand", name = "Poires", quantity = 16,units = "kg", price = 5.50 },
            new Product { emplacement = 1, producer = "Bornand", name = "Pastèques", quantity = 14,units = "pièce", price = 5.50 },
            new Product { emplacement = 1, producer = "Bornand", name = "Melons", quantity = 5,units = "kg", price = 5.50 },
            new Product { emplacement = 2, producer = "Dumont", name = "Noix", quantity = 20,units = "sac", price = 5.50 },
            new Product { emplacement = 2, producer = "Dumont", name = "Raisin", quantity = 6,units = "kg", price = 5.50 },
            new Product { emplacement = 2, producer = "Dumont", name = "Pruneaux", quantity = 13,units = "kg", price = 5.50 },
            new Product { emplacement = 2, producer = "Dumont", name = "Myrtilles", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 2, producer = "Dumont", name = "Groseilles", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 3, producer = "Vonlanthen", name = "Pêches", quantity = 8,units = "kg", price = 5.50 },
            new Product { emplacement = 3, producer = "Vonlanthen", name = "Haricots", quantity = 6,units = "kg", price = 5.50 },
            new Product { emplacement = 3, producer = "Vonlanthen", name = "Courges", quantity = 18,units = "pièce", price = 5.50 },
            new Product { emplacement = 3, producer = "Vonlanthen", name = "Tomates", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 3, producer = "Vonlanthen", name = "Pommes", quantity = 20,units = "kg", price = 5.50 },
            new Product { emplacement = 4, producer = "Barizzi", name = "Poires", quantity = 5,units = "kg", price = 5.50 },
            new Product { emplacement = 4, producer = "Barizzi", name = "Pastèques", quantity = 6,units = "pièce", price = 5.50 },
            new Product { emplacement = 4, producer = "Barizzi", name = "Melons", quantity = 14,units = "kg", price = 5.50 },
            new Product { emplacement = 4, producer = "Barizzi", name = "Noix", quantity = 20,units = "sac", price = 5.50 },
            new Product { emplacement = 4, producer = "Barizzi", name = "Raisin", quantity = 15,units = "kg", price = 5.50 },
            new Product { emplacement = 5, producer = "Blanc", name = "Pruneaux", quantity = 5,units = "kg", price = 5.50 },
            new Product { emplacement = 5, producer = "Blanc", name = "Myrtilles", quantity = 18,units = "kg", price = 5.50 },
            new Product { emplacement = 5, producer = "Blanc", name = "Groseilles", quantity = 10,units = "kg", price = 5.50 },
            new Product { emplacement = 5, producer = "Blanc", name = "Pêches", quantity = 20,units = "kg", price = 5.50 },
            new Product { emplacement = 5, producer = "Blanc", name = "Haricots", quantity = 9,units = "kg", price = 5.50 },
            new Product { emplacement = 6, producer = "Repond", name = "Courges", quantity = 12,units = "pièce", price = 5.50 },
            new Product { emplacement = 6, producer = "Repond", name = "Tomates", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 6, producer = "Repond", name = "Pommes", quantity = 15,units = "kg", price = 5.50 },
            new Product { emplacement = 6, producer = "Repond", name = "Poires", quantity = 18,units = "kg", price = 5.50 },
            new Product { emplacement = 6, producer = "Repond", name = "Pastèques", quantity = 7,units = "pièce", price = 5.50 },
            new Product { emplacement = 7, producer = "Mancini", name = "Pêches", quantity = 10,units = "kg", price = 5.50 },
            new Product { emplacement = 7, producer = "Mancini", name = "Haricots", quantity = 11,units = "kg", price = 5.50 },
            new Product { emplacement = 7, producer = "Mancini", name = "Courges", quantity = 10,units = "pièce", price = 5.50 },
            new Product { emplacement = 7, producer = "Mancini", name = "Tomates", quantity = 13,units = "kg", price = 5.50 },
            new Product { emplacement = 7, producer = "Mancini", name = "Pommes", quantity = 14,units = "kg", price = 5.50 },
            new Product { emplacement = 8, producer = "Favre", name = "Poires", quantity = 5,units = "kg", price = 5.50 },
            new Product { emplacement = 8, producer = "Favre", name = "Pastèques", quantity = 5,units = "pièce", price = 5.50 },
            new Product { emplacement = 8, producer = "Favre", name = "Haricots", quantity = 5,units = "kg", price = 5.50 },
            new Product { emplacement = 8, producer = "Favre", name = "Courges", quantity = 17,units = "pièce", price = 5.50 },
            new Product { emplacement = 8, producer = "Favre", name = "Tomates", quantity = 9,units = "kg", price = 5.50 },
            new Product { emplacement = 9, producer = "Bovay", name = "Pommes", quantity = 13,units = "kg", price = 5.50 },
            new Product { emplacement = 9, producer = "Bovay", name = "Poires", quantity = 5,units = "kg", price = 5.50 },
            new Product { emplacement = 9, producer = "Bovay", name = "Pastèques", quantity = 20,units = "pièce", price = 5.50 },
            new Product { emplacement = 9, producer = "Bovay", name = "Melons", quantity = 20,units = "kg", price = 5.50 },
            new Product { emplacement = 9, producer = "Bovay", name = "Noix", quantity = 13,units = "sac", price = 5.50 },
            new Product { emplacement = 10, producer = "Cherix", name = "Raisin", quantity = 8,units = "kg", price = 5.50 },
            new Product { emplacement = 10, producer = "Cherix", name = "Pruneaux", quantity = 19,units = "kg", price = 5.50 },
            new Product { emplacement = 10, producer = "Cherix", name = "Myrtilles", quantity = 9,units = "kg", price = 5.50 },
            new Product { emplacement = 10, producer = "Cherix", name = "Groseilles", quantity = 10,units = "kg", price = 5.50 },
            new Product { emplacement = 10, producer = "Cherix", name = "Pêches", quantity = 9,units = "kg", price = 5.50 },
            new Product { emplacement = 11, producer = "Beaud", name = "Haricots", quantity = 19,units = "kg", price = 5.50 },
            new Product { emplacement = 11, producer = "Beaud", name = "Courges", quantity = 16,units = "pièce", price = 5.50 },
            new Product { emplacement = 11, producer = "Beaud", name = "Tomates", quantity = 18,units = "kg", price = 5.50 },
            new Product { emplacement = 11, producer = "Beaud", name = "Pommes", quantity = 8,units = "kg", price = 5.50 },
            new Product { emplacement = 11, producer = "Beaud", name = "Poires", quantity = 13,units = "kg", price = 5.50 },
            new Product { emplacement = 12, producer = "Corbaz", name = "Pastèques", quantity = 15,units = "pièce", price = 5.50 },
            new Product { emplacement = 12, producer = "Corbaz", name = "Melons", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 12, producer = "Corbaz", name = "Noix", quantity = 11,units = "sac", price = 5.50 },
            new Product { emplacement = 12, producer = "Corbaz", name = "Raisin", quantity = 16,units = "kg", price = 5.50 },
            new Product { emplacement = 12, producer = "Corbaz", name = "Pruneaux", quantity = 20,units = "kg", price = 5.50 },
            new Product { emplacement = 13, producer = "Amaudruz", name = "Myrtilles", quantity = 18,units = "kg", price = 5.50 },
            new Product { emplacement = 13, producer = "Amaudruz", name = "Groseilles", quantity = 19,units = "kg", price = 5.50 },
            new Product { emplacement = 13, producer = "Amaudruz", name = "Pêches", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 13, producer = "Amaudruz", name = "Haricots", quantity = 13,units = "kg", price = 5.50 },
            new Product { emplacement = 13, producer = "Amaudruz", name = "Courges", quantity = 7,units = "pièce", price = 5.50 },
            new Product { emplacement = 14, producer = "Bühlmann", name = "Tomates", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 14, producer = "Bühlmann", name = "Pommes", quantity = 17,units = "kg", price = 5.50 },
            new Product { emplacement = 14, producer = "Bühlmann", name = "Poires", quantity = 7,units = "kg", price = 5.50 },
            new Product { emplacement = 14, producer = "Bühlmann", name = "Pastèques", quantity = 11,units = "pièce", price = 5.50 },
            new Product { emplacement = 14, producer = "Bühlmann", name = "Melons", quantity = 7,units = "kg", price = 5.50 },
            new Product { emplacement = 15, producer = "Crizzi", name = "Noix", quantity = 10,units = "sac", price = 5.50 },
            new Product { emplacement = 15, producer = "Crizzi", name = "Raisin", quantity = 17,units = "kg", price = 5.50 },
            new Product { emplacement = 15, producer = "Crizzi", name = "Pruneaux", quantity = 18,units = "kg", price = 5.50 },
            new Product { emplacement = 15, producer = "Crizzi", name = "Myrtilles", quantity = 12,units = "kg", price = 5.50 },
            new Product { emplacement = 15, producer = "Crizzi", name = "Groseilles", quantity = 12,units = "kg", price = 5.50 }
        };
            int peach = products.Where(p => p.name == "Pêches").Count();
            //  (from p in products where p.name == "Pêches" select p).Count();
            Console.WriteLine("Il y a " + peach + " vendeurs de pêches");



            Product pasteque = (from p in products where p.name == "Pastèques" orderby p.quantity descending select p).ToList()[0];

            Console.WriteLine("C'est" + pasteque.producer + $" qui a le plus de pastèques (stand {pasteque.emplacement}, {pasteque.quantity}  pièces)");






//             int peaches = 0;
//             foreach (Product product in products)
//             {


//                 if (product.name.ToLower() == "pêches")
//                 {
//                     peaches = peaches + 1;

//                 }
//             }
//             Console.WriteLine($"Nombre de vendeurs de pêches : {peaches}");
//             int pasteque = 0;
//             string vendeur = "";
//             foreach (Product product in products)
//             {
//                 if (product.name.ToLower() == "pastèques")
//                 {
//                     if (product.quantity > pasteque)
//                     {
//                         pasteque = product.quantity;
//                         vendeur = product.producer;
//                     }

//                 }
//             }
// Console.WriteLine($"Nombre de pasteques : {pasteque}, vendeur: {vendeur} ");
        }

    }
}



