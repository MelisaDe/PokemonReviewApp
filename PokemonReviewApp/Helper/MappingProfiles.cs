using AutoMapper;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Country, CountryDto>();

            //CreateMap<CategoryDto, Category>();
            //CreateMap<CountryDto, Country>();
            //CreateMap<OwnerDto, Owner>();
            //CreateMap<PokemonDto, Pokemon>();
            //CreateMap<ReviewDto, Review>();
            //CreateMap<ReviewerDto, Reviewer>();
            //
            //CreateMap<Owner, OwnerDto>();
            //CreateMap<Review, ReviewDto>();
            //CreateMap<Reviewer, ReviewerDto>();
        }
    }
}
