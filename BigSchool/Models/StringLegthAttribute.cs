using System;

namespace BigSchool.Models
{
    internal class StringLegthAttribute : Attribute
    {
        private int v;

        public StringLegthAttribute(int v)
        {
            this.v = v;
        }
    }
}