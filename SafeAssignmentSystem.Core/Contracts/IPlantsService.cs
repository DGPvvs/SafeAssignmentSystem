namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.TransferModels.FactoriesTransferModels;
    using System.Threading.Tasks;

    /// <summary>
    /// Интерфейс деклариращ методи за менажиране на комплекси, инсталации и технологично оборудване
    /// </summary>
    public interface IPlantsService
    {
        /// <summary>
        /// Деклариране на метода за добавяне на комплекси
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task AddComplexAsync(ComplexTransferModel model);

        /// <summary>
        /// Дефиниране на метод връщащ колекция от трансферни модели с всички комплекси
        /// </summary>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public Task<IEnumerable<ComplexTransferModel>> GetAllComplexAsync(bool isDel);

        /// <summary>
        /// Дефиниране на метод връщащ трансферния модел на комплекс с идентификатор id 
        /// </summary>
        /// <param name="id">Идентификатор на комплекс</param>
        /// <returns></returns>
        public Task<ComplexTransferModel> GetComplexByIdAsync(Guid id);

        /// <summary>
        /// Дефиниране на метод редактиращ комплекс 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task EditComplexAsync(ComplexTransferModel model);

        /// <summary>
        /// Дефиниране на метод променящ статуса на полето за изтриване на комплекс
        /// </summary>
        /// <param name="id">Идентификатор на комплекс</param>
        /// <param name="isDel">Статус на комплекса</param>
        /// <returns></returns>
		public Task ChangeDeleteStatusComplexAsync(Guid id, bool isDel);


        /// <summary>
        /// Дефиниране на метод са добавяне на нова инсталация в базата
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public Task AddPlantAsync(PlantTransferModel model);

        /// <summary>
        /// Дефиниране на метод връщащ колекция с данни за инсталациите за които
        /// потребител с идентификатор userId има права 
        /// </summary>
        /// <param name="userId">Идентификатор на потребител</param>
        /// <param name="isAdmin">Указва дали userId е Администратор</param>
        /// <param name="isActive"></param>
        /// <returns></returns>
        public Task<IEnumerable<PlantTransferModel>> GetAllPlantsAsync(Guid userId, bool isAdmin, bool isActive = true);

        /// <summary>
        /// Дефинира метод връщащ трансферен модел с данни за инсталация с идентификатор id
        /// </summary>
        /// <param name="id">Идентификатор на инсталация</param>
        /// <returns></returns>
        public Task<PlantTransferModel> GetPlantByIdAsync(Guid id);

        /// <summary>
        /// Дефинира метод редактиращ инсталация 
        /// </summary>
        /// <param name="model">Трансферен модел с данни за инсталацията</param>
        /// <returns></returns>
        public Task EditPlantAsync(PlantTransferModel model);

        /// <summary>
        /// Дефинира метод добавящ нова технологична позиция в базата данни
        /// </summary>
        /// <param name="model">Трансферен модел с данни за новата технологична позиция</param>
        /// <returns></returns>
        public Task AddTechnologicalPositionAsync(TechnologicalPositionTransferModel model);

        /// <summary>
        /// Дефинира метод връщащ колекция с данни за всички технологични позиции
        /// намиращи с в инсталация с идентификатор id
        /// </summary>
        /// <param name="id">Идентификатор на инсталация</param>
        /// <param name="isDel"></param>
        /// <returns></returns>
        public Task<IEnumerable<TechnologicalPositionTransferModel>> GetAllPositionInPlantByIdAsync(Guid id, bool isDel);

        /// <summary>
        /// Дефинира метод връщащ данни за технологична позиция с идентификатор id
        /// </summary>
        /// <param name="id">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        public Task<TechnologicalPositionTransferModel> GetTechnologicalPositionByIdAsync(Guid id);

        /// <summary>
        /// Дефинира метод редактиращ технологична позиция
        /// </summary>
        /// <param name="model">Данни за технологичната позиция</param>
        /// <returns></returns>
        public Task EditTechnologicalPositionAsync(TechnologicalPositionTransferModel model);

        /// <summary>
        /// Дефинира метод връщащ данни за инсталация, към която се числи технологичната позиция 
        /// с идентификатор positionId
        /// </summary>
        /// <param name="positionId">Идентификатор на технологична позиция</param>
        /// <returns></returns>
        public Task<PlantTransferModel> GetPlantByPositionId(Guid positionId);
    }
}