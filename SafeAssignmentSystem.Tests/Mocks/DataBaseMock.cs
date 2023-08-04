namespace SafeAssignmentSystem.Tests.Mocks
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System;

    public static class DataBaseMock
    {
        public static SafeAssignmentDbContext Instance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<SafeAssignmentDbContext>()                    
                    .UseInMemoryDatabase($"SafeAssignmentDbContext {DateTime.Now.Ticks.ToString()}")                    
                    .Options;

                return new SafeAssignmentDbContext(dbContextOptions, false);
            }
        }
    }
}
