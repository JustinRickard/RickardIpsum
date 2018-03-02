using System;
using System.Collections.Generic;
using System.Linq;
using RickardIpsum.DAL;
using RickardIpsum.DAL.Models;

namespace RickardIpsum.DAL.Repositories
{
    public class IpsumRepository
    {
        Context _ctx;

        public IpsumRepository(Context ctx) {
            _ctx = ctx;
        }

        // GET
        public IEnumerable<DbIpsum> GetAllIpsums() {
            return _ctx.GetNotDeleted<DbIpsum>().ToList();
        }

        public IEnumerable<DbIpsum> GetAllDeletedIpsums() {
            return _ctx.GetDeleted<DbIpsum>().ToList();
        }

        public DbIpsum GetIpsumById(Guid id) {
            return _ctx.GetById<DbIpsum>(id);
        }

        public DbIpsumPhrase GetPhraseById(Guid id) {
            return _ctx.GetById<DbIpsumPhrase>(id);
        }

        public IEnumerable<DbIpsum> SearchIpsums(string searchString) {
            return _ctx.GetNotDeleted<DbIpsum>()
                .Where(x => x.DisplayName.ToLower().Contains(searchString.ToLower()))
                .ToList();
        }

        // CREATE
        public void CreateIpsum(DbIpsum ipsum) {
            _ctx.Create<DbIpsum>(ipsum);
        }        

        public void CreatePhrase(DbIpsumPhrase phrase) {
            _ctx.Create<DbIpsumPhrase>(phrase);
        }

        // UPDATE
        public void UpdateIpsum(DbIpsum ipsum) {
            _ctx.UpdateRecord<DbIpsum>(ipsum);
        }

        public void UpdatePhrase(DbIpsumPhrase phrase) {
            _ctx.UpdateRecord<DbIpsumPhrase>(phrase);
        }

        // DELETE
        public void DeleteIpsum(DbIpsum ipsum) {
            _ctx.Delete<DbIpsum>(ipsum);
        }

        public void DeletePhrase(DbIpsumPhrase phrase) {
            _ctx.Delete<DbIpsumPhrase>(phrase);
        }
    }
}