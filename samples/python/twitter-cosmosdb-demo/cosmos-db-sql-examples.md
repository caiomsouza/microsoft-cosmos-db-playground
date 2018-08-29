

# Queries limitations
Cosmos DB does not support delete. <BR>
Workaround is to use Azure Databricks <BR>
https://github.com/Azure/azure-cosmosdb-spark <BR>
https://github.com/MicrosoftDocs/azure-docs/blob/master/articles/cosmos-db/spark-connector.md <BR>
  
  
Cosmos DB - Query Playground<BR>
https://www.documentdb.com/sql/demo <BR>  


# Tweets Queries 

```

SELECT VALUE COUNT(1) FROM tweets

SELECT * FROM tweets
where tweets.id = "1034752085504475136"

SELECT VALUE COUNT(1) FROM tweets
where tweets.lang = "es"

SELECT top 20 tweets.lang AS test
FROM tweets

SELECT VALUE COUNT(1) FROM tweets
where tweets.user.followers_count = 129

SELECT VALUE COUNT(1) FROM tweets
where tweets.user.followers_count BETWEEN 100000 AND 900000

SELECT * FROM tweets
where tweets.user.followers_count BETWEEN 100000 AND 900000



```
