// See https://aka.ms/new-console-template for more information
 using System.Text.Json;
 
 
 HttpClient client = new HttpClient();

 ////////////////
 var moviesJson = HttpGet(client,"films");

//Conversion Json vers une classe définie
var moviesResult = JsonSerializer.Deserialize<FilmResult>(moviesJson);

//Récupération d'une sous-partie
var movies = moviesResult.results;


System.Console.WriteLine(string.Join(',', movies.Select(m => m.title)));



string HttpGet(HttpClient client,string query)
{
    var json = HttpGetAsync(client,query).ConfigureAwait(false).GetAwaiter().GetResult();
    return json;
}
async Task<string> HttpGetAsync(HttpClient client,string query)
{
    var response = await client.GetAsync(query.Contains("https") ? query : "https://swapi.dev/api/" + query);
    response.EnsureSuccessStatusCode();
    var json = await response.Content.ReadAsStringAsync();

    return json;
}


public static class Extention
{
    public static void Write(this IEnumerable<object> target, char seperator = ',')
    {
        Console.WriteLine(String.Join(target.Select(item=>item.)));
    }
}
//Définition des classes
class FilmResult
{
    public int count { get; set; }
    public List<Film> results { get; set; }
}

class Film
{
    public string title { get; set; }
    public List<string> characters { get; set; }
}



