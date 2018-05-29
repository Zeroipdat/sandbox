using System;
using Paramore.Brighter;

namespace HelloWorld.CustomRetryAttribute
{
    public class SalutationCommand : IRequest
    {
        public SalutationCommand(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; set; }

        public string Name { get; }
    }
}