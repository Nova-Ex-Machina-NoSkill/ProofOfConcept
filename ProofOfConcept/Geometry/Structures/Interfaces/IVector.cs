using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ProofOfConcept.Geometry.Structures.Interfaces
{
    public interface IVector : ICloneable, ISerializable, IXmlSerializable
    {
        bool IsEmpty { get; }
        float X { get; set; }
        float Y { get; set; }
        float Z { get; set; }

        new Vector Clone();
        int CompareTo(Vector v);
        bool Equals(Vector v);
    }
}
