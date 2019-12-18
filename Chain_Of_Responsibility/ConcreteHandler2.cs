using System;

namespace Chain_Of_Responsibility
{
    public class ConcreteHandler2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0} Handle request {1}", this.GetType().Name, request);
            }
            else if (Sucessor != null)
            {
                this.Sucessor.HandleRequest(request);
            }
        }
    }
}
