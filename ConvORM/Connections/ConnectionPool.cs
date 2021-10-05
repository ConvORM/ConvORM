using System.Collections.Generic;

namespace ConvORM.Connections
{
    public static class ConnectionPool
    {
        private static List<Connection> connections;

        public static void RegisterConnection(Connection connection)
        {
            InitializeConnectionsList();
            ValidateConnection(connection);
            connections.Add(connection);
        }

        private static void InitializeConnectionsList()
        {
            if (connections == null)
                connections = new List<Connection>();
        }

        private static void ValidateConnection(Connection connection)
        {
            if (connections.Count > 0)
            {
                if (connections.Find(c => c.Name == connection.Name) != null)
                {
                    //Lançar exceção de conexão existente
                }
            }
        }

        public static Connection GetConnectionByName(string connectionName)
        {
            return (connections.Find(c => c.Name == connectionName));
        }

    }
}
