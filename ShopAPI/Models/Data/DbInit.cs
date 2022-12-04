namespace ShopAPI.Models.Data;

public static class DbInit
{
    public async static void Init(IServiceProvider serviceProvider)
    {
        using (var scope = serviceProvider.CreateScope())
        {
            var _dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        }
    }
}
