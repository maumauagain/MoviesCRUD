using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class GenreEntity : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<MovieEntity> Movies { get; set; }
    }
}
