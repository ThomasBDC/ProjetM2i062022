using MonProjet.Domain.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonProjet.Repository.Voiture
{
    public class VoitureRepository : BaseRepository, IVoitureRepository
    {
        public VoitureRepository() : base()
        {
            
        }
        public List<VoitureModel> GetAllVoitures()
        {
            try
            {
                var cnn = OpenConnexion();

                var sql = "SELECT idVoiture, Marque, Modele, Couleur as laCouleurDeLaVoiture FROM Voiture";

                MySqlCommand cmd = new MySqlCommand(sql, cnn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                List<VoitureModel> allVoitures = new List<VoitureModel>();
                while (rdr.Read())
                {
                    var voitureModel = new VoitureModel()
                    {
                        IdVoiture = Convert.ToInt16(rdr["idVoiture"]),
                        Marque = rdr["Marque"].ToString(),
                        Modele = rdr["Modele"].ToString(),
                        Couleur = rdr["laCouleurDeLaVoiture"].ToString(),
                    };

                    allVoitures.Add(voitureModel);
                }
                rdr.Close();
                cnn.Close();

                return allVoitures;
            }
            catch(Exception e)
            {
                throw new Exception("Une erreur est survenue");
            }
        }
    }
}
