using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CreateAttribute
{
    // Create attribute Version
    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method,
        AllowMultiple=false)]

    public class VersionAttribute : System.Attribute
    {
        // Fields
        private double version;

        // Constructor
        public VersionAttribute(double version)
        {
            this.version = version;
        }

        // Properties
        public double Version 
        {
            get { return this.version; }
        }
    }
}
