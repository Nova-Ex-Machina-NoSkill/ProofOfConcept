using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ProofOfConcept.Geometry.Structures.Interfaces
{
    public interface IPoint : ICloneable, IComparable, ISerializable, IXmlSerializable
    {
        bool IsEmpty { get; }
        float X { get; set; }
        float Y { get; set; }
        float Z { get; set; }

        new Point Clone();

        int CompareTo(Point p);

        bool Equals(Point p);
    }
}
