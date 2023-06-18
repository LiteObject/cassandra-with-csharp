
// Configure the builder with your cluster's contact points
using Cassandra;

internal class Program
{
    private static void Main(string[] args)
    {
        Cluster cluster = Cluster.Builder()
                     .AddContactPoints("localhost")
                     .WithPort(9042)
                     .Build();

        // Connect to the nodes using a keyspace
        ISession session = cluster.Connect();

        // Execute a query on a connection synchronously
        RowSet rs = session.Execute("SELECT * FROM system_schema.tables;");

        // Iterate through the RowSet and print the results
        foreach (Row? row in rs)
        {
            string name = row.GetValue<string>("keyspace_name");
            Console.WriteLine(name);
        }
    }
}