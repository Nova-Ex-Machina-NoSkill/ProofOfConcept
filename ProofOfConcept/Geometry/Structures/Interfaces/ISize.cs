using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ProofOfConcept.Geometry.Structures.Interfaces
{
    public interface ISize : ICloneable, ISerializable, IXmlSerializable
    {
        bool IsEmpty { get; }
        float Width { get; set; }
        float Height { get; set; }

        new Size Clone();
        int CompareTo(Size s);
        bool Equals(Size s);
    }
}
