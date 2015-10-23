namespace KillMe
{
    using Nancy;
    using Nancy.Bootstrapper;
    using Nancy.Responses.Negotiation;

    public class Boostrapper: DefaultNancyBootstrapper
    {
        protected override NancyInternalConfiguration InternalConfiguration
        {
            get
            {
                return
                    NancyInternalConfiguration.WithOverrides(configuration => configuration.ResponseProcessors = new[]
                    {
                        typeof (JsonProcessor)
                    });
            }
        }
    }
}