using AspNetCore.Identity.MongoDbCore.Models;
using MongoDbGenericRepository.Attributes;

namespace MinimalApiMongoAuthProject.Models
{

    [CollectionName("roles")]
    public class ApplicationRole : MongoIdentityRole<Guid>
    {


    }
}
