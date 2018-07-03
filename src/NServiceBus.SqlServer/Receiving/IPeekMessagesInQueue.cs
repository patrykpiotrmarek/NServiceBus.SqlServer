namespace NServiceBus_6.Transport.SQLServer
{
    using System.Threading;
    using System.Threading.Tasks;

    interface IPeekMessagesInQueue
    {
        Task<int> Peek(TableBasedQueue inputQueue, RepeatedFailuresOverTimeCircuitBreaker circuitBreaker, CancellationToken cancellationToken);
    }
}