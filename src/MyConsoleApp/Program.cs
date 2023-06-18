
using Cassandra;

internal class Program
{
    private static async Task Main(string[] args)
    {
        // Configure the builder with your cluster's contact points
        Cluster cluster = Cluster.Builder()
                     .AddContactPoints("localhost")
                     .WithPort(9042)
                     .Build();

        // Connect to the nodes using a keyspace
        ISession session = await cluster.ConnectAsync();

        // Execute a query and print out cluster name
        // RowSet syLocalRS = session.Execute("select * from system.local");
        RowSet syLocalRS = await session.ExecuteAsync(new SimpleStatement("select * from system.local"));
        Console.WriteLine("Cluster Name: " + syLocalRS.First().GetValue<string>("cluster_name"));

        // Execute a query on a connection synchronously
        RowSet sysSchemaRS = session.Execute("SELECT * FROM system_schema.tables;");

        // Iterate through the RowSet and print the results
        foreach (Row? row in sysSchemaRS)
        {
            string name = row.GetValue<string>("keyspace_name");
            Console.WriteLine("Keyspace Name: " + name);
        }        
    }
}