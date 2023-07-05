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
    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;


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
                alreadyDeleted.IsDeleted = IsDeletedCondition.NotDeleted;
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

        public async Task AddPlantAsync(PlantTransferModel model)
        {
            var duplicate = await this.context.PlantInstalations
                .Where(c => c.Name == model.Name || c.FullName == model.FullName)
                .ToListAsync();

            if (duplicate.Any())
            {
                throw new IdentityЕxception();
            }

            var entity = new PlantInstalation()
            {
                FullName = model.FullName,
                Name = model.Name,
                ComplexId = model.ComplexId
            };

            await this.context.PlantInstalations.AddAsync(entity);

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

            var entity = await this.GetCompByIdAsync(model.Id);

			entity.Name = model.Name;
			entity.FullName = model.FullName;

			await this.context.SaveChangesAsync();
		}

        public async Task EditPlantAsync(PlantTransferModel model)
        {
            var alreadyExist = await this.context.PlantInstalations
                .FirstOrDefaultAsync(c => c.Name == model.Name && c.FullName == model.FullName);

            if (!(alreadyExist is null))
            {
                throw new IdentityЕxception();
            }

            var entity = await GetPlnByIdAsync(model.Id);

            entity.Name = model.Name;
            entity.FullName = model.FullName;
            entity.ComplexId = model.ComplexId;

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

        public async Task<IEnumerable<PlantTransferModel>> GetAllPlantsAsync(bool isDel)
        {
            return await this.context.PlantInstalations
                .AsNoTracking()
                .Select(c => new PlantTransferModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    ComplexName = c.Complex.Name
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

        public async Task<PlantTransferModel> GetPlantByIdAsync(Guid id)
        {
            var result = await this.context.PlantInstalations
                .Where(c => c.Id == id)
                .Select(c => new PlantTransferModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                    FullName = c.FullName,
                    ComplexName = c.Complex.Name
                })
                .FirstOrDefaultAsync(c => c.Id == id);

            return result;
        }

        private async Task<ProductionComplex> GetCompByIdAsync(Guid id) => await this.context
            .ProductionComplexes
            .FirstOrDefaultAsync(c => c.Id == id);

        private async Task<PlantInstalation> GetPlnByIdAsync(Guid id) => await this.context
            .PlantInstalations
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}
