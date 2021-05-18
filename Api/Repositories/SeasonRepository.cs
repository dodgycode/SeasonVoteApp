using MongoDB.Driver;
using SeasonVoting.Api.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SeasonVoting.Api.Repositories
{
    public class SeasonRepository : RepositoryBase
    {
        private readonly IMongoCollection<Season> _season;
        public SeasonRepository()
        {
            _season = Database.GetCollection<Season>(CollectionNames.Season);
        }

        public async Task<List<Season>> GetAllAsync()
        {
            return await _season.Find(c => true).ToListAsync();
        }

        public List<Season> GetAll()
        {
            return _season.Find(c => true).ToList();
        }
        public async Task<Season> GetByIdAsync(Guid id)
        {
            return await _season.Find(c => c.Id == id).FirstOrDefaultAsync();
        }
        public async Task<Season> CreateAsync(Season customer)
        {
            await _season.InsertOneAsync(customer);
            return customer;
        }
        public async Task UpdateAsync(Guid id, Season customer)
        {
            await _season.ReplaceOneAsync(c => c.Id == id, customer);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _season.DeleteOneAsync(c => c.Id == id);
        }
    }
}
