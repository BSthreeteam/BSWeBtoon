using Mvcdemo.Model.Repositories;

namespace BSWeBtoon.Front.Services
{
    public class WebtoonService
    {
        private readonly CRUD_data repository;

        public WebtoonService(CRUD_data repository)
        {
            this.repository = repository;
        }

    }
}
