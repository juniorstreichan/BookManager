using System.Collections.Generic;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Interfaces.Service;
using BookManager.Domain.Models;

namespace BookManager.Service.Domain {
    public class PublishingCompanyService : IPublishingCompanyService {
        private readonly IPublishingCompanyRepository _repository;

        public PublishingCompanyService (IPublishingCompanyRepository repository) {
            _repository = repository;
        }

        public PublishingCompany Add (PublishingCompany t) {
            return _repository.Insert (t);
        }

        public PublishingCompany Change (PublishingCompany t) {
            return _repository.Update (t);
        }

        public IEnumerable<PublishingCompany> GetAll () {
            return _repository.FindAll ();
        }

        public PublishingCompany GetById (int id) {
            return _repository.ById (id);
        }

        public void Remove (int id) {
            _repository.Delete (id);
        }
    }
}