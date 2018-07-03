namespace NServiceBus_6.Transport.SQLServer
{
    using System.Threading.Tasks;

    interface IPurgeQueues
    {
        Task<int> Purge(TableBasedQueue queue);
    }
}