using AutoMapper;
using ProjectManager.Application.ViewModels.Core;
using ProjectManager.Domain.Entities.Core;

namespace ProjectManager.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Account, AccountViewModel>();
        }
    }
}