using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    // This interface defines the behavior of "having points."
    //interface IPointy
    //{

    //    // Implicitly public and abstract.
    //    byte GetNumberOfPoints();

    //}

    // Ack! Errors abound!
    //public interface IPointy
    //{
    //    // Error! Interfaces cannot have data fields!
    //    public int numbOfPoints;

    //    // Error! Interfaces do not have constructors!
    //    public IPointy() { numbOfPoints = 0; }

    //    // Error! Interfaces don't provide an implementation of members!
    //    byte GetNumberOfPoints() { return numbOfPoints; }

    //}

    // The pointy behavior as a read-only property.
    public interface 新男女战争
    {
        // A read-write property in an interface would look like:
         bool PropName { get; set; }
        //
        // while a write-only property in an interface would be:
        // retType PropName { set; }

       // byte Points { get;  }
    }

    // The pointy behavior as a read-oly property.
    public interface IPointy
    {
        // A read-write property in an interface would look like:
        // retType PropName { get; set; }
        // while a write-only property in an interface would be:
        // retType PropName { set; }

        byte Points { get; }
    }

}
