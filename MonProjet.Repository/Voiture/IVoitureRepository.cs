using System;
using System.Collections.Generic;
using System.Text;
using MonProjet.Domain.Models;

namespace MonProjet.Repository.Voiture
{
    public interface IVoitureRepository
    {
        public List<VoitureModel> GetAllVoitures();
        public void AddVoiture();
    }
}
