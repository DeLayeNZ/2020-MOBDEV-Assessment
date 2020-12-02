using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using TexasRangers.Models;
using System.Threading.Tasks;

namespace TexasRangers.Data
{
    public class BookingDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public BookingDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Booking>().Wait();
        }

        public Task<List<Booking>> GetBookingAsync()
        {
            return _database.Table<Booking>().ToListAsync();
        }

        public Task<Booking> GetBookingAsync(int id)
        {
            return _database.Table<Booking>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveBookingAsync(Booking booking)
        {
            if (booking.ID != 0)
            {
                return _database.UpdateAsync(booking);
            }
            else
            {
                return _database.InsertAsync(booking);
            }
        }

        public Task<int> DeleteBookingAsync(Booking booking)
        {
            return _database.DeleteAsync(booking);
        }
    }
}
