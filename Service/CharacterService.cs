using Rest_Demo.Data;

namespace Rest_Demo.Service
{
	public class CharacterService : ICharacterService
	{

        private List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{Id=1,Name = "SAM"}
        };
        private readonly IMapper _mapper;
        private readonly DataContext _dataContext;

        public CharacterService(IMapper mapper, DataContext dataContext)
        {
            _mapper = mapper;
            _dataContext = dataContext;
        }

        public ServiceResponse<List<CharacterDTO>> AddCharacter(GetCharacterDTO character)
        {
            var serviceResponse = new ServiceResponse<List<CharacterDTO>>();
            Character newCharacter = _mapper.Map<Character>(character);
            _dataContext.Characters.Add(newCharacter);
            _dataContext.SaveChanges();
            //newCharacter.Id = characters.Max(c => c.Id) + 1;
            //characters.Add(newCharacter);
            
            serviceResponse.Data = GetCharacters();
            return serviceResponse;
        }

        public ServiceResponse<List<CharacterDTO>> GetAllCharacters()
        {
            var serviceResponse = new ServiceResponse<List<CharacterDTO>>();
            serviceResponse.Data = GetCharacters();
            return serviceResponse;
        }

        private List<CharacterDTO> GetCharacters()
        {
            DbSet<Character> characters1 = _dataContext.Characters;
            List<Character> dbCharacters = characters1.ToList();
            return dbCharacters.Select(s => _mapper.Map<CharacterDTO>(s)).ToList();
        }

        public ServiceResponse<CharacterDTO> GetCharacterById(int id)
        {
            var serviceResponse = new ServiceResponse<CharacterDTO>();
            Character character = characters.FirstOrDefault(e => e.Id.Equals(id));
            serviceResponse.Data = _mapper.Map<CharacterDTO>(character);
            return serviceResponse;
            
        }
    }
}

