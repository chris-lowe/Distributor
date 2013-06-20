using System;
using System.Threading;
using Commands;
using NServiceBus;

namespace server.Handlers
{
    public class ChangeUserEmailAddressCommandHandler : IHandleMessages<ChangeUserEmailAddressCommand>
    {
        public void Handle(ChangeUserEmailAddressCommand message)
        {
            Thread.Sleep(100);
            Console.WriteLine("Handled ChangeUserEmailAddressCommand for user {0}", message.UserId);
        }
    }
}
