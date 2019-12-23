namespace Visitor
{
    public class ConcreteElementA : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitVoncreteElementA(this);
        }

        public void OperationA()
        {

        }
    }
}
