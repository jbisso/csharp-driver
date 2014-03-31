using System;

namespace Cassandra.Data.Linq
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class ColumnAttribute : Attribute
    {
        public ColumnAttribute() {}
        public ColumnAttribute(string Name) { this.Name = Name; }
        public string Name = null;
    }
}