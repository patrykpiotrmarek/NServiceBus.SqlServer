namespace NServiceBus_6.Transport.SQLServer
{
    using System;
    using System.Data.SqlClient;
    using System.Threading.Tasks;

    interface ITableBasedQueueOperationsReader
    {
        Func<SqlConnection, SqlTransaction, Task> Get(UnicastTransportOperation operation);
    }
}