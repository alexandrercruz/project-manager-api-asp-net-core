using AutoMapper;
using ProjectManager.Application.ViewModels.Core;
using ProjectManager.Domain.Entities.Core;

namespace ProjectManager.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AccountViewModel, Account>();
            //CreateMap<AccountViewModel, RegisterNewCustomerCommand>()
            //    .ConstructUsing(c => new RegisterNewCustomerCommand(c.Name, c.Email, c.BirthDate));
            //CreateMap<AccountViewModel, UpdateCustomerCommand>()
            //    .ConstructUsing(c => new UpdateCustomerCommand(c.Id, c.Name, c.Email, c.BirthDate));
        }
    }
}