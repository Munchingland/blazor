using Pin.WhatsNew.DefaultLambda.Cons.Models;

#region setup
List<BaseModel> games = new()
{
    new Game 
    {
        Name = "God of War",
        Created  = new DateTime(2015, 04,20),
    },
    new Game
    {
        Name = "Dark Souls: Remastered",
        Created = new DateTime(2018, 05, 23)
    },
    new Game
    {
        Name = "Elden Ring",
        Created = new DateTime(2022, 02, 25),
    },
    new Game
    {
        Name= "Pokemon Scarlet",
        Created = new DateTime(2025, 11, 18),
    }
};

List<BaseModel> developers = new()
{
    new Developer
    {
        Created = new DateTime(1986, 06, 28),
        Name = "Bethesda",
    },
    new Developer
    {
        Created  = new DateTime(2000,07, 1),
        Name = "Double Fine",
    },
    new Developer
    {
        Created  = new DateTime(1986, 11, 1),
        Name = "FromSoftware",
    },
    new Developer
    {
        Created  = new DateTime(1989,04,26),
        Name = "Game Freak",
    }
};
#endregion

///Ik zie er persoonlijk niet echt het nut van in want het lijkt me erg op een methode. Enige verschil is dat het iets sneller geschreven wordt.
//Hier heb ik een lambda met een simple filter op naam waarvan als geen string parameter wordt meegegeven is dit een spatie.
//Ik zie niet echt waar ik dit in de opleiding zou nog uitgevoerd hebben aangezien ik ook gewoon een methode kan schrijven.
//zoals hier gedemonstreert heb ik dezelfde resultaten.
//Ik zie mezelf dit niet echt gebruiken in de toekomst tenzij dit de voorkeur is van het team dat ik in werk.
var filterByName = (List<BaseModel> toFilter, string filter = " " ) =>
{
    return toFilter.Where(g => g.Name.ToUpper().Contains(filter.ToUpper())).ToList();
};

List<BaseModel> FilterByNameMethod(List<BaseModel> toFilter, string filter = " ")
{
    return toFilter.Where(g => g.Name.ToUpper().Contains(filter.ToUpper())).ToList();
}


var filtered = filterByName(games,"o");
foreach (var game in filtered)
{
    Console.WriteLine(game.Name);
}
Console.WriteLine("------------------------------------------------------------------");

var filterDev = filterByName(developers, "from");
foreach (var dev in filterDev)
{
    Console.WriteLine(dev.Name);
}
Console.WriteLine("------------------------------------------------------------------");

var filterGameMethod = FilterByNameMethod(games, "o");
foreach (var game in filterGameMethod)
{ 
    Console.WriteLine(game.Name); 
}
Console.WriteLine("------------------------------------------------------------------");

var filterDevMethod = FilterByNameMethod(developers, "from");
foreach (var dev in filterDevMethod)
{
    Console.WriteLine(dev.Name);
}
Console.WriteLine("------------------------------------------------------------------");