using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;
using BookManager.Infra.Context;

namespace BookManager.Infra.Repository {
    public class PublishingCompanyRepository:
        BaseRepository<PublishingCompany>, IPublishingCompanyRepository {
            public PublishingCompanyRepository (BookManagerContext context) : base (context) { }
        }
}