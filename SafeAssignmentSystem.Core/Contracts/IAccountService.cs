namespace SafeAssignmentSystem.Core.Contracts
{
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.TransferModels;
    using SafeAssignmentSystem.Core.Models.TransferModels.UserTransferModels;
    using System;
    using System.Threading.Tasks;


    /// <summary>
    /// Интерфейс дефиниращ методите за работа с потребителските акаунти
    /// </summary>
    public interface IAccountService
    {
        /// <summary>
        /// Дефиниция на метода за редактиране на потребителски акаунти
        /// </summary>
        /// <param name="model">Трансферен модел</param>
        /// <param name="AdministratorUserName">Потребителско име на текущо логнатия администратор</param>
        /// <returns></returns>
        public Task<StatusModel> EditAccount(RegisterUserTransferModel model, string AdministratorUserName);

        /// <summary>
        /// Дефиниция на метода връщащ колекция с трансферния модел на всички акаунти
        /// с изключение на текущо логнат администратор
        /// </summary>
        /// <param name="currentUserName">Потребителско име на текущо логнатия администратор</param>
        /// <returns></returns>
        public Task<IEnumerable<UserTransferModel>> GetAllUsers(string currentUserName);

        /// <summary>
        /// Дефиниция на метод връщащ колекция от трансферни модели на всички потребители
        /// с роли Оператор и Дежурен електротехник
        /// </summary>
        /// <param name="currentUserName"></param>
        /// <returns></returns>
        public Task<IEnumerable<UserTransferModel>> GetAllUsersWhithRole(string currentUserName);

        /// <summary>
        /// Дефиниция на метод показващ дали потребителя с идентификатор userId
        /// има права за оборудването в инсталация с идентификатор plantId 
        /// </summary>
        /// <param name="userId">Идентификатор на потребител</param>
        /// <param name="plantId">Идетнификатор на инсталация</param>
        /// <returns></returns>
        public Task<bool> HasUserPremisionForPlant(Guid userId, Guid plantId);

        /// <summary>
        /// дефиниция на метод показващ дали потребителя има права да се логне в системата
        /// </summary>
        /// <param name="user">Потребител</param>
        /// <returns></returns>
        public Task<StatusModel> LoginPermissionAsync(UserTransferModel user);

        /// <summary>
        /// Дефиниране на метод регистриращ нов потребител
        /// </summary>
        /// <param name="model">Трансферен модел с данните на потребителя</param>
        /// <returns></returns>
        public Task<StatusModel> RegisterUserAsync(RegisterUserTransferModel model);
    }
}
