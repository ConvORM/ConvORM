using ConvORM.Connections.Drivers;
using ConvORM.Connections.Enum;
using System;

namespace ConvORM.Connections
{
    public abstract class Connection
    {
        public EConnectionStates State { get; set; }
        public string Name { get; set; }
        public bool EnableDebugLogger { get; set; }
        protected IConnectionDriver ConnectionDriver { get; set; }

        #region Events

        public event EventHandler OpenConnection;

        #endregion

    }
}
