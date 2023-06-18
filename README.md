# Apache Cassandra with C#
>Cassandra is an open-source, NoSQL database that manages large amounts of data across multiple servers. It is designed to be highly available, meaning it can continue to function even if some of its nodes fail. Cassandra is decentralized and scalable, and it provides high availability without a single point of failure.

## Cassandra vs MongoDB
>MongoDB is a document store database that works with collections containing multiple documents, whereas Cassandra is a column-oriented database.

>MongoDB has a master-slave architecture, while Cassandra has a peer-to-peer architecture where all are master nodes in communication with each other.

|   |Cassandra|MongoDB|
|---|---|---|
|Pros|Highly available and scalable|Flexible and easy to use|
||Good for handling large amounts of data and traffic|Good for storing and querying unstructured data|
||Open source|Open source|
|Cons|Not as flexible as MongoDB|Not as highly available or scalable as Cassandra|
||Not as good for storing unstructured data|Not as good for handling large amounts of data and traffic|
---
## Here are some common concepts in Cassandra:
- Keyspace:
A keyspace is a top-level namespace that defines data replication and other settings. It is similar to a database in the relational database world.
- Column Family/Table: 
In Cassandra, data is organized into column families or tables. Each column family consists of rows that can have different numbers and types of columns. Column families are similar to tables in a relational database.
- Column: 
A column is the basic unit of data storage in Cassandra. Each column has a name, value, and a timestamp. Columns are grouped together in rows or records.
- Primary Key:
A primary key is a unique identifier for a row in a Cassandra table. It consists of one or more columns that uniquely identify each row.
- Partition Key:
The partition key is part of the primary key and determines the partition in which the data is stored. Data in Cassandra is distributed across multiple nodes based on the partition key, allowing for scalable and distributed data storage.
- Clustering Columns:
Clustering columns are additional columns used to define the sorting order within a partition. They determine how data is ordered within a partition.
- Replication:
Cassandra is designed to be highly available and fault-tolerant. It achieves this through replication, where data is automatically copied and stored on multiple nodes. Replication factor and consistency level settings control how many copies of the data are stored and how consistency is maintained during read and write operations.
- Consistency Level: 
 Consistency level determines how many replicas need to respond to a read or write operation before it is considered successful. It defines the trade-off between consistency and availability in a distributed system.
 - Data Model:
 Cassandra follows a denormalized data model, where data is duplicated and stored in multiple tables to optimize read performance. It supports flexible schema design and allows for efficient querying using secondary indexes.
 - Tombstones:
 Tombstones are special markers used in Cassandra to represent deleted data. They are necessary to ensure eventual consistency in a distributed system and to propagate deletions across all replicas.
 
---

## Links
* [Get Started with Apache Cassandra](https://cassandra.apache.org/_/quickstart.html)
* [DataStax C# Driver for Apache Cassandra](https://github.com/datastax/csharp-driver)
