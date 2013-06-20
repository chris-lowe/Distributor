using System;
using System.Threading;
using Commands;
using NServiceBus;

namespace server
{
    public class CreateUserCommandHandler : IHandleMessages<CreateUserCommand>
    {
        public void Handle(CreateUserCommand message)
        {
            Thread.Sleep(300);
            Console.WriteLine("Handled CreateUserCommand for user {0}", message.UserId);
        }
    }
}
