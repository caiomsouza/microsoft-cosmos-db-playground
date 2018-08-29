using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.Linq;

namespace cosmodb_lab {


// https://cosmosdb.github.io/labs/technical_deep_dive/02-creating_multi_partition_solution.html#setup


public class Program
 { 

     private static readonly Uri _endpointUri = new Uri("https://msldncosmosdblab.documents.azure.com:443/");
     private static readonly string _primaryKey = "<YOUR_KEY>";



     public static async Task Main(string[] args)  
     {    


         using (DocumentClient client = new DocumentClient(_endpointUri, _primaryKey))
         {
             await client.OpenAsync();
             Uri collectionLink = UriFactory.CreateDocumentCollectionUri("EntertainmentDatabase", "CustomCollection");
             var tvInteractions = new Bogus.Faker<WatchLiveTelevisionChannel>()
                 .RuleFor(i => i.type, (fake) => nameof(WatchLiveTelevisionChannel))
                 .RuleFor(i => i.minutesViewed, (fake) => fake.Random.Number(1, 45))
                 .RuleFor(i => i.channelName, (fake) => fake.PickRandom(new List<string> { "NEWS-6", "DRAMA-15", "ACTION-12", "DOCUMENTARY-4", "SPORTS-8" }))
                 .Generate(500);
             foreach(var interaction in tvInteractions)
             {
                 ResourceResponse<Document> result = await client.CreateDocumentAsync(collectionLink, interaction);
                 await Console.Out.WriteLineAsync($"Document #{tvInteractions.IndexOf(interaction):000} Created\t{result.Resource.Id}");
             }
         }
 




         
/* Lab 2

     using (DocumentClient client = new DocumentClient(_endpointUri, _primaryKey))
     {
         await client.OpenAsync();
         Uri collectionLink = UriFactory.CreateDocumentCollectionUri("EntertainmentDatabase", "CustomCollection");
         var foodInteractions = new Bogus.Faker<PurchaseFoodOrBeverage>()
             .RuleFor(i => i.type, (fake) => nameof(PurchaseFoodOrBeverage))
             .RuleFor(i => i.unitPrice, (fake) => Math.Round(fake.Random.Decimal(1.99m, 15.99m), 2))
             .RuleFor(i => i.quantity, (fake) => fake.Random.Number(1, 5))
             .RuleFor(i => i.totalPrice, (fake, user) => Math.Round(user.unitPrice * user.quantity, 2))
             .Generate(500);
         foreach(var interaction in foodInteractions)
         {
             ResourceResponse<Document> result = await client.CreateDocumentAsync(collectionLink, interaction);
             await Console.Out.WriteLineAsync($"Document #{foodInteractions.IndexOf(interaction):000} Created\t{result.Resource.Id}");
         }
     }     
 

*/





         /* Lab 1



         using (DocumentClient client = new DocumentClient(_endpointUri, _primaryKey))
         {

         }
         
         using (DocumentClient client = new DocumentClient(_endpointUri, _primaryKey))
         {
                
                
            Database targetDatabase = new Database { Id = "EntertainmentDatabase" };
            targetDatabase = await client.CreateDatabaseIfNotExistsAsync(targetDatabase);
            await Console.Out.WriteLineAsync($"Database Self-Link:\t{targetDatabase.SelfLink}");




         }


        using (DocumentClient client = new DocumentClient(_endpointUri, _primaryKey))
         {

                await client.OpenAsync();
                Uri databaseLink = UriFactory.CreateDatabaseUri("EntertainmentDatabase");

                DocumentCollection defaultCollection = new DocumentCollection 
                 {      Id = "DefaultCollection"  };

                defaultCollection = await client.CreateDocumentCollectionIfNotExistsAsync(databaseLink, defaultCollection);
                await Console.Out.WriteLineAsync($"Default Collection Self-Link:\t{defaultCollection.SelfLink}"); 

                        
         }

        // Create an Unlimited Collection using the SDK

        using (DocumentClient client = new DocumentClient(_endpointUri, _primaryKey))
        {

             await client.OpenAsync();
             Uri databaseLink = UriFactory.CreateDatabaseUri("EntertainmentDatabase");

             IndexingPolicy indexingPolicy = new IndexingPolicy
             {
                 IndexingMode = IndexingMode.Consistent,
                 Automatic = true,
                 IncludedPaths = new Collection<IncludedPath>
                 {
                     new IncludedPath
                     {
                         Path = "/*",
                         Indexes = new Collection<Index>
                         {
                             new RangeIndex(DataType.Number, -1),
                             new RangeIndex(DataType.String, -1)                           
                         }
                     }
                 }
             };                

             PartitionKeyDefinition partitionKeyDefinition = new PartitionKeyDefinition
             {
                 Paths = new Collection<string> { "/type" }
             };


             DocumentCollection customCollection = new DocumentCollection
             {
                 Id = "CustomCollection",
                 PartitionKey = partitionKeyDefinition,
                 IndexingPolicy = indexingPolicy
             };  
                
             RequestOptions requestOptions = new RequestOptions
             {
                 OfferThroughput = 10000
             };


             customCollection = await client.CreateDocumentCollectionIfNotExistsAsync(databaseLink, customCollection, requestOptions); 
                
             await Console.Out.WriteLineAsync($"Custom Collection Self-Link:\t{customCollection.SelfLink}");  

                
         }


        */





     }
 }


}
