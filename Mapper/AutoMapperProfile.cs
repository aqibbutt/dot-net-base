using System;

namespace Rest_Demo.Mapper
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Character, GetCharacterDTO>();
			CreateMap<Character, CharacterDTO>();
            CreateMap<GetCharacterDTO, Character>();
        }
	}
}

