using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Testing.Mock
{
    public class DbMock
    {
        public static LibraryDbContext Instance
        {
            get
            {
                var options = new DbContextOptionsBuilder<LibraryDbContext>()
                    .UseInMemoryDatabase("LibraryInMemoryDb" + Guid.NewGuid().ToString())
                    .Options;

                return new LibraryDbContext(options, false);
            }
        }
    }
}
