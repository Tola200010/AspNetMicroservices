﻿namespace Ordering.Domian.Common
{
    public abstract class EntityBase
    {
        public int Id { get;protected set; }
        public string? CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string? LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
