using System;

namespace ProofOfConcept.DesignPatterns.Creational.Prototype
{
    public abstract class Shape : ICloneable
    {
        private string id;
        protected string type;

        public string Id { get { return id; } set { id = value; } }
        public string Type { get { return type; } }

        abstract public void Draw();

        public object Clone()
        {
            var tmp = (Shape)this.MemberwiseClone();
            tmp.id = new string(id.ToCharArray());
            tmp.type = new string(type.ToCharArray());
            return tmp;
        }

        public Shape()
        {
            id = "";
            type = "";
        }

        public Shape(string type) : this(type, "") { }

        public Shape(string type, string id)
        {
            this.id = id;
            this.type = type;
        }

        public Shape(Shape shape)
        {
            id = shape.id;
            type = shape.type;
        }
    }
}