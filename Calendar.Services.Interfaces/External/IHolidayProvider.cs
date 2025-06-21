using Calendar.Entities.DTOs;

namespace Calendar.Services.Interfaces.External
{
    public interface IHolidayProvider
    {
        Task<List<HolidayDTO>> GetHolidaysAsync(int year, string countryCode);
    }
}
