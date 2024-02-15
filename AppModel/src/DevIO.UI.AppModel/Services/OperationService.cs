namespace DevIO.UI.AppModel.Services
{
    public class OperationService
    {

        public OperationService(IOperationTransient transient,
                                IOperationScoped scoped,
                                IOperationSingleton singleton,
                                IOperationSingletonInstance singletonInstance)
        {
            Transient = transient;
            Scoped = scoped;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public IOperationTransient Transient { get; }
        public IOperationScoped Scoped { get; }
        public IOperationSingleton Singleton { get; }
        public IOperationSingletonInstance SingletonInstance { get; }
    }

    public class Operation : IOperationTransient, 
                             IOperationScoped, 
                             IOperationSingleton, 
                             IOperationSingletonInstance
    {
        public Operation() : this(Guid.NewGuid()) { }
        public Operation(Guid id)
        {
            OperationId = id;
        }

        public Guid OperationId { get; private set; }
    }

    public interface IOperation
    {
        Guid OperationId { get; }
    }

    public interface IOperationTransient : IOperation { }
    public interface IOperationScoped : IOperation { }
    public interface IOperationSingleton : IOperation { }
    public interface IOperationSingletonInstance : IOperation { }


}
