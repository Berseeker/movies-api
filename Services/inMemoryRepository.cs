using MoviesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Services
{
    public class inMemoryRepository: IRepository
    {
        private List<Gender> _genders;
        public inMemoryRepository()
        {
            _genders = new List<Gender>()
            {
                new Gender() {Id = 1, Name = "Comedy"},
                new Gender() {Id = 2, Name = "Action"}
            };
        }

        public async  Task<List<Gender>> GetAllGenders()
        {
            await Task.Delay(1);
            return _genders;
        }

        public Gender GetGenderById(int Id)
        {
            return _genders.FirstOrDefault(x => x.Id == Id);
        }

        public void AddGender(Gender gender)
        {
            gender.Id = _genders.Max(x => x.Id) + 1;
            _genders.Add(gender);
        }
    }
}
