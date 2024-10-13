using FastEndpoints;

namespace WebApplication1.Controllers
{
    public class WeatherForecastController : Endpoint<DtoIn, DtoOut>
    {
        public override void Configure()
        {
            Post("/test");
            Description(b => b.Produces(200));
            AllowAnonymous();
        }
        public override async Task HandleAsync(DtoIn req, CancellationToken ct)
        {
            await SendOkAsync(new DtoOut()
            {
                Surname = req.Name + "Teste"
            }, ct);
        }
    }

    public class DtoIn
    {
        public string Name { get; set; }
    }

    public class DtoOut
    {
        public string Surname { get; set; }
    }
}
