# Microsoft Cosmos DB Playground

# Microsoft Labs <BR>
https://cosmosdb.github.io/labs/ <BR>
https://github.com/CosmosDB/labs <BR>
https://www.linkedin.com/in/aliuy/ <BR>	

Cosmos DB - Query Playground<BR>
https://www.documentdb.com/sql/demo

Azure Cosmos DB Python examples <BR>
https://docs.microsoft.com/en-gb/azure/cosmos-db/sql-api-python-samples <BR>
https://github.com/Azure/azure-documentdb-python <BR>
https://github.com/CosmosDB <BR>


Price <BR>
Request Units (RU) = % Memory, % CPU, % IOPS = RU is a rate-based currency.<BR>
1 RU = 1 read of 1 KB record<BR>

Pricing Example
- Storage cost
- Throughput

Big = $ 100.000 / month<BR>
Medium =  Range from $ 1000 to $ 3000 / month<BR>


SQL is the native API (Microsoft).<BR>

Types:
- Key-value = Table API
- Cassandra = Column-family 
- MongoDB = Document 
- Gremlin = Graph 

Cosmos DB Customers<BR>
- Domino's Pizza  = Global Distributed Apps
	-Single online website to order pizza for all restaurants 
	
- IoT (Internet of Things) - Telemetry & Sensor Data = Toyota, Honeywell, LG CNS, Johnson Controls
		○ Business  Needs:
			§ High scalability to ingest large # of events coming from many devices
			§ Low latency queries and changes feeds for responding quickly to anomalies 
			§ Schema-agnostic storage and automatic indexing to support dynamic data coming from many different generations of devices 
			§ High availability across multiple data centers 
		○ Real-time Recommendations 
			§ Use Azure Databricks + Cosmos DB + Azure Container Services (Recommendations API)
				□ Online Recommendations Service
				□ Order Transactions 
		○ Customer 360 - Operational Analytics = Real Madrid 
			§ Azure Databricks on top of Cosmos DB
				□ Scale-out Computation = Azure Databricks 
				□ Scale-out Database = Cosmos DB
			§ Spark Connector using SQL API
			Apache Spark on Databricks 



Walmart Cosmos DB - Use Case From startups to big-business: Using functional programming techniques to transform line of<BR>
https://www.youtube.com/watch?v=dSCzCaiWgLM <BR>	

Where to Store Your Data in Azure? Understand Azure Data Storage Options <BR>
https://stackify.com/store-data-azure-understand-azure-data-storage-options/ <BR>
	
			
# Partition - Consistent hashing
https://en.wikipedia.org/wiki/Consistent_hashing<BR>

The Simple Magic of Consistent Hashing <BR>
https://dzone.com/articles/simple-magic-consistent<BR>

Distributed Web Caching System with Consistent Hashing <BR>
https://dspace.mit.edu/bitstream/handle/1721.1/80121/43563161-MIT.pdf?sequence=2<BR>

Consistent hashing and random trees : algorithms for caching in distributed networks <BR>
https://dspace.mit.edu/handle/1721.1/9947<BR>

Consistent hashing and random trees : algorithms for caching in distributed networks <BR>
https://www.cs.princeton.edu/courses/archive/fall09/cos518/papers/chash.pdf<BR>

David Karger <BR>
http://people.csail.mit.edu/karger/<BR>
http://people.csail.mit.edu/karger/Papers/thesis.pdf<BR>
https://scholar.google.com/citations?user=2vQRGrYAAAAJ<BR>

Consistent Hashing in Cassandra <BR>
https://blog.imaginea.com/consistent-hashing-in-cassandra/<BR>
https://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archDataDistributeHashing.html<BR>

# Indexing

How does Azure Cosmos DB index data? <BR>
https://docs.microsoft.com/en-us/azure/cosmos-db/indexing-policies <BR>


System Properties Comparison Amazon DynamoDB vs. Microsoft Azure Cosmos DB vs. Titan<BR>
https://db-engines.com/en/system/Amazon+DynamoDB%3BMicrosoft+Azure+Cosmos+DB%3BTitan

Cost Comparison: Azure Cosmos DB vs. DynamoDB vs. Neptune <BR>
https://dzone.com/articles/azure-cosmos-db-costs-vs-dynamo-db-and-neptune <BR>


# Azure Databricks + Cosmos DB
https://github.com/Azure/azure-cosmosdb-spark
https://docs.azuredatabricks.net/spark/latest/data-sources/azure/cosmosdb-connector.html
https://docs.databricks.com/spark/latest/data-sources/azure/cosmosdb-connector.html#use-the-azure-cosmos-db-spark-connector <BR>
https://github.com/MicrosoftDocs/azure-docs/blob/master/articles/cosmos-db/spark-connector.md <BR>
https://github.com/Azure/azure-cosmosdb-spark/tree/2.3/samples/notebooks <BR>

Accelerate big data analytics by using the Apache Spark to Azure Cosmos DB connector <BR>
https://docs.microsoft.com/en-us/azure/cosmos-db/spark-connector <BR>

Structured streaming with Azure Databricks into Power BI & Cosmos DB <BR>
http://www.mnazureusergroup.com/2018/06/25/structured-streaming-with-azure-databricks-into-power-bi-cosmos-db/ <BR>
	
Streaming Live Tweets from Twitter to CosmosDB <BR>
http://sajeetharan.blogspot.com/2018/05/streaming-live-tweets-from-twitter-to.html <BR>
https://github.com/sajeetharan/CosmosdbTweetsStream <BR>
	
Structured streaming with Azure Databricks into Power BI & Cosmos DB<BR>
https://azure.microsoft.com/en-us/blog/structured-streaming-with-databricks-into-power-bi-cosmos-db/ <BR>

Choosing a big data storage technology in Azure <BR>
https://docs.microsoft.com/en-us/azure/architecture/data-guide/technology-choices/data-storage <BR>

Configuring Power BI Direct Query to Azure Cosmos DB via Apache Spark (HDI)<BR>
https://github.com/Azure/azure-cosmosdb-spark/wiki/Configuring-Power-BI-Direct-Query-to-Azure-Cosmos-DB-via-Apache-Spark-(HDI) <BR><BR>

Lambda Architecture with Azure Cosmos DB and HDInsight (Apache Spark) <BR>
https://github.com/Azure/azure-cosmosdb-spark/blob/master/samples/lambda/readme.md <BR>

On-Time Flight Performance with Spark and Cosmos DB (Seattle) <BR>
https://github.com/Azure/azure-cosmosdb-spark/blob/master/samples/notebooks/On-Time%20Flight%20Performance%20with%20Spark%20and%20Cosmos%20DB%20-%20Seattle.ipynb <BR>	

Twitter Source with Apache Spark and Azure Cosmos DB Change Feed <BR>
https://github.com/Azure/azure-cosmosdb-spark/blob/master/samples/notebooks/Twitter%20with%20Spark%20and%20Azure%20Cosmos%20DB%20Change%20Feed.ipynb <BR>	
	
More links: <BR>
https://www.jamesserra.com/ <BR>
https://www.linkedin.com/in/jamesserra/ <BR>	
https://www.slideshare.net/jamserra/introduction-to-azure-databricks-83448539 <BR>
https://www.slideshare.net/jamserra/power-bi-for-big-data-and-the-new-look-of-big-data-solutions <BR>
https://www.jamesserra.com/archive/2017/10/use-cases-of-various-products/ <BR>
https://www.jamesserra.com/archive/2018/06/understanding-cosmos-db/ <BR>
	
	
	






