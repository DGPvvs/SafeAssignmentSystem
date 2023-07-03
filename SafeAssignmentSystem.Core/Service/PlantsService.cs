namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Data;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;


    public class PlantsService : IPlantsService
    {
        private readonly SafeAssignmentDbContext context;

        public PlantsService(SafeAssignmentDbContext context)
        {
            this.context = context;
        }

        public async Task AddComplexAsync(ComplexTransferModel model)
        {
            var alreadyDeleted = await this.context.ProductionComplexes
                .FirstOrDefaultAsync(c => (c.Name == model.Name || c.FullName == model.FullName) && c.IsDeleted);

            if (!(alreadyDeleted is null))
            {
                alreadyDeleted.IsDeleted = false;
                await this.context.SaveChangesAsync();
                return;
            }

            var duplicate = await this.context.ProductionComplexes
                .Where(c => c.Name == model.Name || c.FullName == model.FullName)
                .ToListAsync();

            if (duplicate.Any())
            {
                throw new IdentityЕxception();
            }

            var entity = new ProductionComplex()
            {
                FullName = model.FullName,
                Name = model.Name,
                IsDeleted = model.IsDeleted
            };           

            await this.context.ProductionComplexes.AddAsync(entity);

            await this.context.SaveChangesAsync();
        }

		public async Task DeleteComplexAsync(Guid id, bool isDel)
		{
			var entity = await GetCompByIdAsync(id);

            if (entity is null)
            {
                throw new NullReferenceException();
			}

            if (entity.PlantInstalations.Count > 0)
            {
                throw new NotEmptyException(Complex_Has_Plant);
			}

			entity.IsDeleted = isDel;

            await this.context.SaveChangesAsync();
		}

		public async Task EditComplexAsync(ComplexTransferModel model)
		{
            var alreadyExist = await this.context.ProductionComplexes
                .FirstOrDefaultAsync(c => c.Name == model.Name && c.FullName == model.FullName && !c.IsDeleted);

            if (!(alreadyExist is null))
            {
				throw new IdentityЕxception();
			}

			alreadyExist = await this.context.ProductionComplexes
				.FirstOrDefaultAsync(c => c.Name == model.Name && c.FullName == model.FullName && c.IsDeleted);

            if (!(alreadyExist is null))
            {
				throw new IdentityЕxception(Complex_Edit_Exist_In_Deleted);
			}

            var entity = await GetCompByIdAsync(model.Id);

			entity.Name = model.Name;
			entity.FullName = model.FullName;

			await this.context.SaveChangesAsync();
		}

		public async Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync(bool isDel)
        {
            return await this.context.ProductionComplexes
                .Where(c => c.IsDeleted == isDel)
                .AsNoTracking()
                .Select(c => new ComplexTransferModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    IsDeleted = c.IsDeleted,
                    PlantInstalations = c.PlantInstalations
                })
                .ToListAsync();
        }

        public async Task<ComplexTransferModel> GetComplexByIdAsync(Guid id)
        {
            var result = await this.context.ProductionComplexes
                .Where(c => c.Id == id)
                .Select(c => new ComplexTransferModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    IsDeleted = c.IsDeleted,
                    PlantInstalations = c.PlantInstalations
                })
                .FirstOrDefaultAsync(c => c.Id == id);

            return result;            
        }

        private async Task<ProductionComplex> GetCompByIdAsync(Guid id)
        {
			var result = await this.context.ProductionComplexes
				.FirstOrDefaultAsync(c => c.Id == id);

			return result;
		}
	}
}
