namespace Company.Consumers
{
    using System.Threading.Tasks;
    using MassTransit;
    using Contracts;
    using Microsoft.Extensions.Logging;

    public class MensageriaConsumer :
        IConsumer<Mensageria>
    {
        readonly ILogger<Mensageria> _logger;

        public MensageriaConsumer(ILogger<Mensageria> logger)
        {
            _logger = logger;
        }

        public Task Consume(ConsumeContext<Mensageria> context)
        {
            _logger.LogInformation("Received Text: {Text}", context.Message.Value);
            return Task.CompletedTask;
        }
    }
}