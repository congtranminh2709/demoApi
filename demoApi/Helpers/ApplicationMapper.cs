using AutoMapper;
using demoApi.Data;
using demoApi.Models;

namespace demoApi.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<PersonModel, Person>().ReverseMap();
        }
    }
}
