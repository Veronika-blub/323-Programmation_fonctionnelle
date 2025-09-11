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

            var i18n = new Dictionary<string, string>()
        {
            { "Pommes","Apples"},
            { "Poires","Pears"},
            { "Pastèques","Watermelons"},
            { "Melons","Melons"},
            { "Noix","Nuts"},
            { "Raisin","Grapes"},
            { "Pruneaux","Plums"},
            { "Myrtilles","Blueberries"},
            { "Groseilles","Berries"},
            { "Tomates","Tomatoes"},
            { "Courges","Pumpkins"},
            { "Pêches","Peaches"},
            { "Haricots","Beans"}
        };



            //Les 3 premières lettres du producteur suivies de "..." suivis de la dernière lettre du nom (Dumont --> Dum...t) [pseudo-anonymisation]
            List<string> anonymizedProducers = products
                .Select(p => $"{p.producer[0]}{p.producer[1]}{p.producer[2]}...{p.producer[^1]}")
                .ToList();
            Console.WriteLine("Producteurs anonymisés :" + string.Join(",\n", anonymizedProducers));



            //Le nom de l’aliment en anglais dictionnaire disponible ici
            List<string> productNamesInEnglish = products
                .Select(p => i18n.ContainsKey(p.name) ? i18n[p.name] : p.name)
                .ToList();
            Console.WriteLine("Noms des aliments en anglais :" + string.Join(",\n", productNamesInEnglish));

            //Le chiffre d’affaire maximum possible de la journée avec cet aliment (CA = Quantity * PricePerUnit)
            List<double> maxRevenue = products
                .Select(p => p.quantity * p.price)
                .ToList();

            Console.WriteLine("Chiffre d'affaire maximum possible de la journée : " + string.Join(",\n", maxRevenue) + " CHF");

            //tableau avec [Seller, Product, CA]
            var salesData = products
                .Select(p => new { Seller = p.producer, Product = p.name, CA = p.quantity * p.price })
                .ToList();
            Console.WriteLine("Données de vente (Vendeur, Produit, CA) :");
            foreach (var data in salesData)
            {
                Console.WriteLine($"{data.Seller}, {data.Product}, {data.CA} CHF");
            }

            var modifiedData = products.Select(p => new
            {
                Seller = $"{p.producer[0]}{p.producer[1]}{p.producer[2]}...{p.producer[^1]}",
                Product = i18n.ContainsKey(p.name) ? i18n[p.name] : p.name,
                CA = p.quantity * p.price
            }).ToList();
            Console.WriteLine("Données modifiées (Vendeur Anonymisé, Produit en Anglais, CA) :");
            foreach (var data in modifiedData)
            {
                Console.WriteLine($"{data.Seller}, {data.Product}, {data.CA} CHF");
            }
        }
    }
}


