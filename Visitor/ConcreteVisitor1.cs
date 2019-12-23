using System;

namespace Visitor
{
    public class ConcreteVisitor1 : Visitor
    {
        public override void VisitVoncreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitVoncreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0} visitado por {1}", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
}
