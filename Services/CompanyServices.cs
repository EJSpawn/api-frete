namespace Freight.Services
{
    using Freight.Models;
    using System.Collections.Generic;
    using System.Linq;

    public interface ICompanyService {
        Company GetById(long id);
        void Save(Company company);

        IList<Company> GetAll();
    }

    public class CompanyService : ICompanyService
    {
        private readonly IList<Company> _companyRepository;

        public CompanyService(){
            _companyRepository = new List<Company>(){
                new Company(){Id = 1,Name = "Empresa 1", Freight = 23},
                new Company(){Id = 2,Name = "Empresa 2", Freight = 14},
                new Company(){Id = 3,Name = "Empresa 3", Freight = 7}
            };
        }

        public Company GetById(long id)
        {
            return _companyRepository.Where(c => c.Id == id).SingleOrDefault();
        }

        public void Save(Company company)
        {
            _companyRepository.Add(company);
        }

        public IList<Company> GetAll()
        {
            return _companyRepository;
        }
    }
}
