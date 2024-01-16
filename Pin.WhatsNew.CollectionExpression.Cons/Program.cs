using Pin.LiveSports.Core;


//de collection expressie lijkt mij wel heel nuttig. Wegens het initializeren en opvullen van een lijst, array en zo is een heel stuk eenvoudiger.

//Het is een feature dat ik denk dat in elk deel van de opleiding wel gebruikt kan worden wegens het gemakkelijk gebruik en hoe regelmatig lists en zo worden gebruikt

//Het maakt het initialiseren van alles die een collectie is ook gelijk. Het kunnen mixen van enkel toevoegen of een collectie toevoegen aan de hand van de spread operater lijkt mij
//ook heel interessant. het is iets dat als de mogelijkheid er is zal ik dit wel gebruiken

//bv in deze opdracht bij reporter deed ik het origineel zo
Console.WriteLine("Oude manier :");
var oldPhases = new List<string>
{
    Constants.Start
};

var oldToAdd = GetPhasesInTournament();
foreach (var add in oldToAdd)
{
    oldPhases.Add(add);
}
foreach (string phase in oldPhases)
{
    Console.WriteLine(phase);
}
Console.WriteLine("--------------------------------------------------------------------------------------------");
//terwijl op de nieuwe manier kan het zo
Console.WriteLine("Nieuwe manier :");
List<string> phases = [Constants.Start];
var newToAdd = GetPhasesInTournament();

phases = [.. phases, .. newToAdd];

foreach (string phase in phases)
{
    Console.WriteLine(phase);
}
Console.WriteLine("--------------------------------------------------------------------------------------------");
//of nog korter
Console.WriteLine("nieuwe kortere manier :");
var shortToAdd = GetPhasesInTournament();
phases = [Constants.Start, .. shortToAdd];
foreach (string phase in phases)
{
    Console.WriteLine(phase);
}
Console.WriteLine("--------------------------------------------------------------------------------------------");
//ook de return van methodes kan je hier gebruiken zonder probleem. Niet aangeraden maar wel mogelijk
Console.WriteLine("functie in expressie:");
IEnumerable<string> phasesNumerable = oldPhases;

string[] phasesArray = [..GetPhasesInTournament(), "Hi", ..phasesNumerable  ];
foreach (string phase in phasesArray)
{
    Console.WriteLine(phase);
}

List<string> GetPhasesInTournament()
{
    return new List<string>() { Constants.Intro, Constants.Single, Constants.Combo, Constants.SwitchStance, Constants.Air, Constants.Power, Constants.Final };
}