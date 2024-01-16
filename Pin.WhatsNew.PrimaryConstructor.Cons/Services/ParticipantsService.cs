using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using Pin.WhatsNew.PrimaryConstructor.Cons.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.WhatsNew.PrimaryConstructor.Cons.Services
{
    //Hier wordt via de primary constructor de IWindSurferService meegegeven waardoor deze geinjecteerd wordt zonder je een gewoon constructor moet uit typen
    internal class ParticipantsService(IWindSurferService surferService) : IParticipantsService
    {
        private readonly IWindSurferService _surferService = surferService;

        public List<WindSurfer> GetPossibleSurfers()
        {
            return _surferService.GetAll();
        }
    }
}
