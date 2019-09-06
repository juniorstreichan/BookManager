using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BookManager.Domain.Interfaces.Repository;
using BookManager.Domain.Models;

namespace BookManager.Mock.Repository {
    public class PublishingCompanyRepository : IPublishingCompanyRepository {
        private List<PublishingCompany> _data = new List<PublishingCompany> {
            new PublishingCompany { Id = 1, Name = "Simon & Schuster	EUA" },
            new PublishingCompany { Id = 2, Name = "Egmont group	Dinamarca / Noruega " },
            new PublishingCompany { Id = 3, Name = "Woongjin ThinkBig	Coréia do Sul" },
            new PublishingCompany { Id = 4, Name = "RCS Libri	Itália	513	6063" }
        };

        public PublishingCompany ById (int id) {
            try {
                return _data.First (a => a.Id == id);
            } catch (System.Exception) {
                return null;
            }
        }

        public void Delete (int id) {
            var obj = ById (id);

            if (obj != null) {
                _data.Remove (obj);
            }
        }

        public IQueryable<PublishingCompany> Find (Expression<Func<PublishingCompany, bool>> expression) {
            return _data.AsQueryable ().Where (expression);
        }

        public IEnumerable<PublishingCompany> FindAll () {
            return _data;
        }

        public PublishingCompany Insert (PublishingCompany entity) {
            _data.Add (entity);
            return entity;
        }

        public PublishingCompany Update (PublishingCompany entity) {
            var obj = ById (entity.Id);

            if (obj != null) {
                _data.Remove (obj);
                _data.Add (entity);
            }

            return ById (entity.Id);
        }

    }
}