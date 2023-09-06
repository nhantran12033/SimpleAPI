
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAPI.BusinessTrip
{
    public interface IBusinessTripAppService
    {
        public Task<InformationDto> CreateAsync(InformationDto dto);
        public Task<List<InformationDto>> GetListAsync();
        public Task DeleteAsync(Guid id);
    }
}
