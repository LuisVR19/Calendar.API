using Calendar.Entities.DTOs;
using Calendar.Services.Interfaces.External;
using System.Net.Http.Json;

namespace Calendar.Infrastructure.Holidays
{
    public class HolidayProvider : IHolidayProvider
    {
        private readonly HttpClient _httpClient;

        public HolidayProvider(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<HolidayDTO>> GetHolidaysAsync(int year, string countryCode)
        {
            var url = $"https://date.nager.at/api/v3/PublicHolidays/{year}/{countryCode}";
            var response = await _httpClient.GetFromJsonAsync<List<HolidayDTO>>(url);

            return response;
        }
    }
}
