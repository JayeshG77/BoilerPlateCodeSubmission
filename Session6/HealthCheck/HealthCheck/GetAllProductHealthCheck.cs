using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Session4.Context;

namespace Session4.HealthCheck
{
    public class GetAllProductHealthCheck : IHealthCheck
    {
        readonly AppDbContext _appDbContext;

        public GetAllProductHealthCheck(AppDbContext appDbContext)
        {
                _appDbContext = appDbContext;
        }
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                var list = await _appDbContext.Products.ToListAsync();
                //throw new Exception("Error");
                return HealthCheckResult.Healthy();
            }
            catch (Exception ex)
            {
                return HealthCheckResult.Unhealthy(ex.Message);
            }
        }


    }
}
