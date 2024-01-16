using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.WhatsNew.PrimaryConstructor.Cons.Services.Interface
{
    public interface IParticipantsService
    {
        public List<WindSurfer> GetPossibleSurfers();
    }
}
