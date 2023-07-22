namespace SafeAssignmentSystem.Core.Service
{
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using SafeAssignmentSystem.Common.Exceptions;
    using SafeAssignmentSystem.Common.Exeptions;
    using SafeAssignmentSystem.Common.Notification;
    using SafeAssignmentSystem.Core.Contracts;
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using SafeAssignmentSystem.DataBase.Data.Common;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.FactoryModels;
    using SafeAssignmentSystem.DataBase.Data.FactoryModels;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using static SafeAssignmentSystem.Common.Notification.ConditionConstants;
    using static SafeAssignmentSystem.Common.Notification.NotificationConstants;

    public class PlantsService : IPlantsService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IRepository repo;

        public PlantsService(
            UserManager<ApplicationUser> userManager,
            IRepository repo)
        {
            this.repo = repo;
            this.userManager = userManager;
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

        /// <summary>
        /// Задава стойност на IsDeleted в класа ProductionComplex isDel 
        /// </summary>
        /// <param name="id">Идентификационен ключ</param>
        /// <param name="isDel">Параметър, чиято стойност се сетва в IsDeleted</param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException"></exception>
        /// <exception cref="NotEmptyException"></exception>
        public async Task ChangeDeleteStatusComplexAsync(Guid id, bool isDel)
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

            await this.repo.SaveChangesAsync();
        }

        /// <summary>
        /// Редактиране на комплекс
        /// </summary>
        /// <param name="model">Модел на сомплекса, който се редактира</param>
        /// <returns></returns>
        /// <exception cref="IdentityЕxception"></exception>
		public async Task EditComplexAsync(ComplexTransferModel model)
        {
            var alreadyExist = await this.repo.AllReadonly<ProductionComplex>()
                .FirstOrDefaultAsync(c => c.Name == model.Name && c.FullName == model.FullName && !c.IsDeleted);

            if (!(alreadyExist is null))
            {
                throw new IdentityЕxception();
            }

            alreadyExist = await this.repo.AllReadonly<ProductionComplex>()
                .FirstOrDefaultAsync(c => c.Name == model.Name && c.FullName == model.FullName && c.IsDeleted);

            if (!(alreadyExist is null))
            {
                throw new IdentityЕxception(Complex_Edit_Exist_In_Deleted);
            }

            var entity = await this.GetCompByIdAsync(model.Id);

            entity!.Name = model.Name;
            entity.FullName = model.FullName;

            await this.repo.SaveChangesAsync();
        }

        /// <summary>
        /// Редактиране на инсталация
        /// </summary>
        /// <param name="model">Модел на инсталацията, която се редактира</param>
        /// <returns></returns>
        /// <exception cref="IdentityЕxception"></exception>
        public async Task EditPlantAsync(PlantTransferModel model)
        {
            var alreadyExist = await this.repo.AllReadonly<PlantInstalation>()
                .FirstOrDefaultAsync(c => c.Name == model.Name && c.FullName == model.FullName);

            if (!(alreadyExist is null))
            {
                throw new IdentityЕxception();
            }

            var entity = await GetPlnByIdAsync(model.Id);

            entity!.Name = model.Name;
            entity.FullName = model.FullName;
            entity.ComplexId = model.ComplexId;

            await this.repo.SaveChangesAsync();
        }

        /// <summary>
        /// Редакция на технологична позиция
        /// </summary>
        /// <param name="model">Модел на технологичната позиция, която се редактира</param>
        /// <returns></returns>
        /// <exception cref="IdentityЕxception"></exception>
        public async Task EditTechnologicalPositionAsync(TechnologicalPositionTransferModel model)
        {
            var duplicate = await this.repo.AllReadonly<TechnologicalPosition>()
                .Where(i => i.InstalationId == model.InstalationId)
                .FirstOrDefaultAsync(tp => tp.Name == model.Name);

            if (!(duplicate is null))
            {
                throw new IdentityЕxception();
            }

            var entity = await GetTechnPositionByIdAsync(model.Id);

            entity!.Name = model.Name;
            entity.InstalationId = model.InstalationId;

            await this.repo.SaveChangesAsync();
        }

        /// <summary>
        /// Връща списък с комплекси в зависимост от параметъра isDel
        /// ако isDel = false, връща списък на неизтритите комплекси
        /// ако isDel = true, връща списък с изтритите комплекси
        /// </summary>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync(bool isDel)
        {
            return await this.repo.AllReadonly<ProductionComplex>()
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

        /// <summary>
        /// Връща списък с инсталациите
        /// в зависимост от флага isAdmin
        /// isAdmin = true - връща всички инсталации
        /// isAdmin = false - връща само инсталациите достъпни за потребителя с Id = userId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="isAdmin"></param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public async Task<IEnumerable<PlantTransferModel>> GetAllPlantsAsync(Guid userId, bool isAdmin, bool isActive = true)
        {
            if (isAdmin)
            {
                return await this.repo.AllReadonly<PlantInstalation>()
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
            else
            {
                return await this.repo.AllReadonly<ApplicationUserPlantInstalation>()
                    .Where(au => au.UserId == userId && au.IsActive == isActive)
                    .AsNoTracking()
                    .Select(au => new PlantTransferModel()
                    {
                        Id = au.Instalation.Id,
                        Name = au.Instalation.Name,
                        FullName = au.Instalation.FullName,
                        ComplexName = au.Instalation.Complex.Name
                    })
                    .ToListAsync();
            }
        }

        /// <summary>
        /// Връща списък с технологичните позиции в инсталация
        /// сочена от id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TechnologicalPositionTransferModel>> GetAllPositionInPlantByIdAsync(Guid id, bool isDel)
        {
            return await this.repo.AllReadonly<TechnologicalPosition>()
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

        /// <summary>
        /// Връща комплекс със зададеното id в трансферният модел на комплексите
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<ComplexTransferModel> GetComplexByIdAsync(Guid id)
        {
            var result = await this.repo.AllReadonly<ProductionComplex>()
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

        /// <summary>
        /// Връща инсталация със зададеното id в трансферният модел на инсталациите
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<PlantTransferModel> GetPlantByIdAsync(Guid id)
        {
            var result = await this.repo.AllReadonly<PlantInstalation>()
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

        /// <summary>
        /// Връща инсталация, към която се числи технологичната позиция
        /// с идентификатор positionId 
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        /// <exception cref="Exception">Хвърля изключение ако не е намерена технологичната позиция</exception>
        public async Task<PlantTransferModel> GetPlantByPositionId(Guid positionId)
        {
            var position = await this.repo.AllReadonly<TechnologicalPosition>()
                .AsNoTracking()
                .Where(pi => pi.Id.Equals(positionId))
                .FirstOrDefaultAsync();

            if (position is null)
            {
                throw new TechnologicalPositionException();
            }

            return new PlantTransferModel()
            {
                Id = position.Instalation.Id,
                Name = position.Instalation.Name,
                FullName = position.Instalation.FullName,
                ComplexName = position.Instalation.Complex.FullName
            };
        }

        /// <summary>
        /// Връща технологичната позиция със зададеното id в трансферният модел на технологичните позиции
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<TechnologicalPositionTransferModel> GetTechnologicalPositionByIdAsync(Guid id)
        {
            var result = await this.repo.AllReadonly<TechnologicalPosition>()
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

        /// <summary>
        /// Връца комплекс по зададено Id
        /// </summary>
        /// <param name="id">Идентификационен ключ</param>
        /// <returns></returns>
        private async Task<ProductionComplex?> GetCompByIdAsync(Guid id) => await this.repo
            .AllReadonly<ProductionComplex>()
            .FirstOrDefaultAsync(c => c.Id == id);

        /// <summary>
        /// Връща инсталация по зададено id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task<PlantInstalation?> GetPlnByIdAsync(Guid id) => await this.repo
            .AllReadonly<PlantInstalation>()
            .FirstOrDefaultAsync(c => c.Id == id);

        /// <summary>
        /// Връща технологична позиция по зададено id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private async Task<TechnologicalPosition?> GetTechnPositionByIdAsync(Guid id) => await this.repo
            .AllReadonly<TechnologicalPosition>()
            .FirstOrDefaultAsync(tp => tp.Id == id);
    }
}
