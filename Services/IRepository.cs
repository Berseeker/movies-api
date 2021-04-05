using MoviesApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApi.Services
{
    public interface IRepository
    {
        List<Gender> GetAllGenders();
        Gender GetGenderById(int Id);
    }
}
