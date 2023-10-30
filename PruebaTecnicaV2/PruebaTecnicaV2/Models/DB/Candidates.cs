using System;
using System.Collections.Generic;

namespace PruebaTecnicaV2.Models.DB
{
    public partial class Candidates
    {
        public Candidates()
        {
            Candidateexperiences = new HashSet<Candidateexperiences>();
        }

        public int IdCandidate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Email { get; set; }
        public DateTime? InsertDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual ICollection<Candidateexperiences> Candidateexperiences { get; set; }
    }
}
