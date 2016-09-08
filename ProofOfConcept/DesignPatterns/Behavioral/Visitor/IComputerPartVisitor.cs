﻿namespace ProofOfConcept.DesignPatterns.Behavioral.Visitor
{
    public interface IComputerPartVisitor
    {
        void Visit(Computer computer);
        void Visit(Mouse mouse);
        void Visit(Keyboard keyboard);
        void Visit(Monitor monitor);
    }
}
