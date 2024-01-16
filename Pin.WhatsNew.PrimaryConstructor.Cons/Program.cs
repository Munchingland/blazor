using Microsoft.Extensions.DependencyInjection;
using Pin.LiveSports.Core.Services;
using Pin.LiveSports.Core.Services.Interfaces;
using Pin.WhatsNew.PrimaryConstructor.Cons.Model;
using Pin.WhatsNew.PrimaryConstructor.Cons.Services;
using Pin.WhatsNew.PrimaryConstructor.Cons.Services.Interface;


//Ik vind primary constructor de max. Je kan zo veel code werk besparen hierdoor. Met dat je geen constructer meer nodig hebt voor bv.Dependency injection.
//Dit is iets dat je in de volledige opleiding kan gebruiken vooral dan waar dependency inject voor komt maar ook om bv, een parameter voordien in te vullen.
//BV. de volledige naam van een student waarvan na het invullen je deze parameters niet meer nodig hebt
//hier is enkel student.FullName beschikbaar. En de class bevat ook geen tussen variable voor firstName of LastName.
//Enkel maar wat zich bevindt in de primary constructor
var student = new Student("jarno", "Caenepeel");
Console.WriteLine(student.FullName);


//primary constructor in de participants Service bevat de IWindSurferService. Waardoor daar geen constructor meer extra moet aan gemaakt
//worden en is dependency injection persoonlijk heel wat simpeler geworden
var serviceProvider = new ServiceCollection().AddSingleton<IWindSurferService, WindSurferService>().AddSingleton<IParticipantsService, ParticipantsService>().BuildServiceProvider();
var parService = serviceProvider.GetService<IParticipantsService>();

var surfers = parService.GetPossibleSurfers();

foreach (var surfer in surfers)
{
    Console.WriteLine(surfer.Name);
}
