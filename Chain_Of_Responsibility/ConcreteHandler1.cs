using System;

namespace Chain_Of_Responsibility
{
    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} Handle request {1}", this.GetType().Name, request);
            }else if (Sucessor != null)
            {
                this.Sucessor.HandleRequest(request);
            }
        }
    }
}
