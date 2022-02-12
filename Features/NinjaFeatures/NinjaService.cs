using AutoMapper;
using InfoNinjasApi.Data;
using Microsoft.EntityFrameworkCore;

namespace InfoNinjasApi.Features.NinjaFeatures
{
    public interface INinjaService
    {
        Task<List<NinjaItemDto>> GetAllNinjas();
    }

    public class NinjaService : INinjaService
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;

        public NinjaService(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<NinjaItemDto>> GetAllNinjas()
        {
            var allNinjas = await _context.NinjaItems.ToListAsync();
            return _mapper.Map<List<NinjaItemDto>>(allNinjas);
        }
    }
}
