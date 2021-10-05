using ConvORM.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConvORM.Connections.Drivers
{
    public interface IConnectionDriver
    {
        bool Open(string connectionString);
        int ExecuteCommand(string sql);
        int ExecuteCommand(string sql, Dictionary<string, object> parameters);
        Entity ExecuteScalarQuery(string sql, Type entityType);
        IList ExecuteQuery(string sql, Type entityType);
        int GetLastInsertedId();
    }
}
