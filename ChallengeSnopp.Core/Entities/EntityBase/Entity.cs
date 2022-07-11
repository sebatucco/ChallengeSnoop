using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ChallengeSnopp.Core.Entities.EntityBase
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}
