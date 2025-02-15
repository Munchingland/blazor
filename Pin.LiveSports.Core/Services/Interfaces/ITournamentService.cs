﻿using Pin.LiveSports.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services.Interfaces
{
    public interface ITournamentService
    {
        void CreateTournament(List<WindSurfer> competitors, string name);
        List<Tournament> GetAll();
        Tournament GetById(int id);
        void UpdateTournament(Tournament tournamentToUpdate, List<WindSurfer> competitors, List<WindSurfer>notCompeting);
        List<MatchUpdate> GetTournamentHistory(int tournamentId);
        List<string> GetPhasesInTournament();
    }
}
