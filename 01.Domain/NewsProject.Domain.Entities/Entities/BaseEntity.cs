using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Entities
{
    public abstract class BaseEntity<T> : IBaseEntity
    {
        public T Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int InsertBy { get; set; }
        public int UpdateBy { get ; set; }
    }
}
