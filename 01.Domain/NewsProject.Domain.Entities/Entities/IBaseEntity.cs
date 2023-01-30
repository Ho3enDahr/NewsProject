using System;

namespace NewsProject.Domain.Entities.Entities
{
    public interface IBaseEntity
    {
        int InsertBy { get; set; }
        DateTime InsertDate { get; set; }
        int UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
    }
}