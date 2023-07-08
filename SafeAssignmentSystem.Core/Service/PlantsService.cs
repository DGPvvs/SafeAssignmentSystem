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
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.Common;

    public class PlantsService : IPlantsService
    {
        private readonly SafeAssignmentDbContext context;
        private readonly IRepository repo;

        public PlantsService(
            SafeAssignmentDbContext context,
            IRepository repo)
        {
            this.context = context;
            this.repo = repo;
        }

        /// <summary>
        /// Добавяне на нов комплекс в базата.
        /// Ако комплекса вече е бил създаван, но е изтрит, се възстановява от изтритите комплекси.
        /// </summary>
        /// <param name="model">Трансферен модел на данните за комплекс.</param>
        /// <returns></returns>
        /// <exception cref="IdentityЕxception">Изключение за идентичност. 
        /// Предизвиква се ако вече съществува комплекс с такива имена.
        /// </exception>
        public async Task AddComplexAsync(ComplexTransferModel model)
        {
            var alreadyDeleted = await this.repo.All<ProductionComplex>()
                .FirstOrDefaultAsync(c => (c.Name == model.Name || c.FullName == model.FullName) && c.IsDeleted);

            if (!(alreadyDeleted is null))
            {
                alreadyDeleted.IsDeleted = IsDeletedCondition.NotDeleted;
                await this.repo.SaveChangesAsync();
                return;
            }

            var duplicate = await this.repo.AllReadonly<ProductionComplex>()
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

            await this.repo.AddAsync(entity);

            await this.repo.SaveChangesAsync();
        }

        /// <summary>
        /// Добавяне на нова инсталация в базата.
        /// </summary>
        /// <param name="model">Трансферен модел на данните за инсталация.</param>
        /// <returns></returns>
        /// <exception cref="IdentityЕxception">Изключение за идентичност. 
        /// Предизвиква се ако вече съществува инсталация с такива имена.
        /// </exception>
        public async Task AddPlantAsync(PlantTransferModel model)
        {
            var duplicate = await this.repo.AllReadonly<PlantInstalation>()
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

            await this.repo.AddAsync(entity);

            await this.repo.SaveChangesAsync();
        }

        /// <summary>
        /// Добавяне на нова технологична позиция в базата.
        /// </summary>
        /// <param name="model">Трансферен модел на данните за технологична позиция.</param>
        /// <returns></returns>
        /// <exception cref="IdentityЕxception">Изключение за идентичност. 
        /// Предизвиква се ако в инсталацията вече съществува технологична позиция с такова име.
        /// </exception>
        public async Task AddTechnologicalPositionAsync(TechnologicalPositionTransferModel model)
        {
            var duplicate = await this.repo.AllReadonly<TechnologicalPosition>()
                .Where(i => i.InstalationId == model.InstalationId)
                .FirstOrDefaultAsync(tp => tp.Name == model.Name);

            if (!(duplicate is null))
            {
                throw new IdentityЕxception();
            }

            var entity = new TechnologicalPosition()
            {
                Name = model.Name,
                InstalationId = model.InstalationId
            };

            await this.repo.AddAsync(entity);

            await this.repo.SaveChangesAsync();
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

			entity!.Name = model.Name;
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

            entity!.Name = model.Name;
            entity.FullName = model.FullName;
            entity.ComplexId = model.ComplexId;

            await this.context.SaveChangesAsync();
        }

        public async Task EditTechnologicalPositionAsync(TechnologicalPositionTransferModel model)
        {
            var duplicate = await this.context.TechnologicalPositions
                .Where(i => i.InstalationId == model.InstalationId)
                .FirstOrDefaultAsync(tp => tp.Name == model.Name);

            if (!(duplicate is null))
            {
                throw new IdentityЕxception();
            }

            var entity = await GetTechnPositionByIdAsync(model.Id);

            entity!.Name = model.Name;
            entity.InstalationId = model.InstalationId;

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

        public async Task<IEnumerable<TechnologicalPositionTransferModel>> GetAllPositionInPlantByIdAsync(Guid id, bool isDel)
        {
            return await this.context.TechnologicalPositions
                .AsNoTracking()
                .Where(tp => tp.InstalationId == id)
                .Select(tp => new TechnologicalPositionTransferModel()
                {
                    Id = tp.Id,
                    Name = tp.Name,
                    InstalationName = tp.Instalation.FullName,
                    ComplexName = tp.Instalation.Complex.FullName
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

            return result!;            
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

            return result!;
        }

        public async Task<TechnologicalPositionTransferModel> GetTechnologicalPositionByIdAsync(Guid id)
        {
            var result = await this.context.TechnologicalPositions
                .Where(tp => tp.Id == id)
                .Select(tp => new TechnologicalPositionTransferModel()
                {
                    Id = tp.Id,
                    Name = tp.Name,
                    InstalationId = tp.InstalationId,
                    InstalationName = tp.Instalation.Name,
                    ComplexName = tp.Instalation.Complex.FullName
                })
                .FirstOrDefaultAsync(tp => tp.Id == id);

            return result!;

        }

        private async Task<ProductionComplex?> GetCompByIdAsync(Guid id) => await this.context
            .ProductionComplexes
            .FirstOrDefaultAsync(c => c.Id == id);

        private async Task<PlantInstalation?> GetPlnByIdAsync(Guid id) => await this.context
            .PlantInstalations
            .FirstOrDefaultAsync(c => c.Id == id);

        private async Task<TechnologicalPosition?> GetTechnPositionByIdAsync(Guid id) => await this.context
            .TechnologicalPositions
            .FirstOrDefaultAsync(tp => tp.Id == id);
    }
}
