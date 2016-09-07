using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.DesignPatterns.Creational.Singleton
{
    public class SingleObject
    {
        private static SingleObject instance;

        static SingleObject()
        {
            instance = new SingleObject();
        }

        private SingleObject() { }

        public static SingleObject GetInstance()
        {
            return instance;
        }

        public override string ToString()
        {
            return "Hello World!";
        }
    }
}
