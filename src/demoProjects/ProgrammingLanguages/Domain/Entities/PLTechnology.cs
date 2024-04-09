using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PLTechnology : Entity
    {
        public int ProgrammingLanguageId { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseTime { get; set; }
        public ProgrammingLanguage? ProgrammingLanguage { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime DeletedTime { get; set; }

        public PLTechnology()
        {
            
        }

        public PLTechnology(int id, int programmingLanguageId, string name, DateTime releaseTime,  DateTime createdTime) : this()
        {
            Id = id;
            ProgrammingLanguageId = programmingLanguageId;
            Name = name;
            ReleaseTime = releaseTime;
            CreatedTime = createdTime;
        }
    }
}
