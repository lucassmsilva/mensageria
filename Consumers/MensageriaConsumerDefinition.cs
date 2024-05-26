namespace Company.Consumers
{
    using MassTransit;

    public class MensageriaConsumerDefinition :
        ConsumerDefinition<MensageriaConsumer>
    {
        protected override void ConfigureConsumer(IReceiveEndpointConfigurator endpointConfigurator, IConsumerConfigurator<MensageriaConsumer> consumerConfigurator)
        {
            endpointConfigurator.UseMessageRetry(r => r.Intervals(500, 1000));
        }
    }
}