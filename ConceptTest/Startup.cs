
namespace ConceptTest;

public class Startup
{
    public static IServiceProvider? ServiceProvider { get; set; }
    public static void Initialize(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;
    }
    public static T GetService<T>()
    {
        return ServiceProvider.GetService<T>();
    }
}
