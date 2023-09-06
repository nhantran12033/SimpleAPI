using System.Threading.Tasks;

namespace SimpleAPI.Data;

public interface ISimpleAPIDbSchemaMigrator
{
    Task MigrateAsync();
}
