using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services
{
    public class WindSurferService : IWindSurferService
    {
        private Random random = new Random();
        private static List<WindSurfer> _windSurfers;

        public WindSurferService()
        {
            _windSurfers = new List<WindSurfer>();
            CreateRandomWindSurfers(10);

        }

        private void CreateRandomWindSurfers(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                WindSurfer surfer = new WindSurfer
                {

                    Id = i,
                    Name = $"Surfer{i}"

                };
                _windSurfers.Add(surfer);
            }
        }

        public List<WindSurfer> GetAll()
        {
            return _windSurfers;
        }

        public void AddSurfer(WindSurfer windSurfer)
        {
            windSurfer.Id = _windSurfers.Max(c => c.Id) + 1;
            _windSurfers.Add(windSurfer);
        }
    }
}
