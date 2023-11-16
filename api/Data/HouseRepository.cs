using Microsoft.EntityFrameworkCore;

public interface IHouseRepository
{
    Task<List<HouseDto>> GetAll();
}

public class HouseRepository: IHouseRepository
{
    private readonly HouseDbContext context;
    public HouseRepository(HouseDbContext context)
    {
        this.context = context;
    }

    public async Task<List<HouseDto>> GetAll()
    {
        var houses = await context.Houses.Select(h => new HouseDto(h.Id, h.Address, h.Country, h.Description, h.Price)).ToListAsync();
        return houses;
    }
}