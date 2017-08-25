using StructureMap;
using System;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class TestRegistry : Registry
    {
        public TestRegistry()
        {
            Scan(config =>
            {
                config.TheCallingAssembly();
                config.ConnectImplementationsToTypesClosing(typeof(IApplicationEventHandler<>));
                config.WithDefaultConventions();
            });
        }
    }

    public interface IApplicationEventHandler<TEvent> where TEvent : IEvent
    {
        Task Handle(TEvent @event);
    }

    public interface IEvent
    {
    }

    public class Created : IEvent
    {

    }

    public class EventHandler : IApplicationEventHandler<Created>
    {
        public Task Handle(Created @event)
        {
            throw new NotImplementedException();
        }
    }

    public class EventHandler2 : IApplicationEventHandler<Created>
    {
        public Task Handle(Created @event)
        {
            throw new NotImplementedException();
        }
    }
}
