using MonProjet.Domain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MonProjet.Repository.Voiture
{
    public class VoitureRepository :  IVoitureRepository
    {
        private List<VoitureModel> allVoitures { get; set; }
        public VoitureRepository()
        {
            allVoitures = new List<VoitureModel>()
            {
                new VoitureModel()
                {
                    IdVoiture = 1,
                    Couleur = "Bleu",
                    Marque = "Peugeot",
                    Modele = "308"
                },
                new VoitureModel()
                {
                    IdVoiture = 1,
                    Couleur = "Rouge",
                    Marque = "Ferrari",
                    Modele = "458 Italia"
                }
            };
        }
        public List<VoitureModel> GetAllVoitures()
        {
            return allVoitures.OrderBy(voiture => voiture.Marque).ToList();
        }

        public void AddVoiture()
        {
            allVoitures.Add(new VoitureModel()
            {
                IdVoiture = 1,
                Couleur = "Jaune",
                Marque = "Lamborghini",
                Modele = "Murciélago"
            });
        }
    }
}
