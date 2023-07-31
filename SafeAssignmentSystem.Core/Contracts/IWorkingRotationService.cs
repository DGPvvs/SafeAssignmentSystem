namespace SafeAssignmentSystem.Core.Contracts
{
    using Microsoft.AspNetCore.Http;
    using SafeAssignmentSystem.Common.Overrides;
    using SafeAssignmentSystem.Core.Models.StatusModels;
    using SafeAssignmentSystem.Core.Models.WorkingRotationTransfetModels;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Интерфейс дефиниращ сървис манипулиращ с данните за смените и сменните графици
    /// </summary>
    public interface IWorkingRotationService
    {
        /// <summary>
        /// Дефенера метод добавящ нова смяна в базата данни
        /// </summary>
        /// <param name="transfer">Модел с данни за новата смяна</param>
        /// <returns></returns>
        public Task AddShiftAsync(ShiftTransferModel transfer);

        /// <summary>
        /// дефинира метод за редакция на съществуваща смяна
        /// </summary>
        /// <param name="transfer">Модел с данни за смяната</param>
        /// <returns></returns>
        public Task EditShiftAsync(ShiftTransferModel transfer);

        /// <summary>
        /// Дефинира метод връщащ колекция с всички смени регистрирани в базата данни
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<ShiftTransferModel>> GetAllShiftAsync();

        /// <summary>
        /// Дефинира метод връщащ смяна с идентификатор id
        /// </summary>
        /// <param name="id">Идентификатор на смяна</param>
        /// <returns></returns>
        public Task<ShiftTransferModel> GetShiftByIdAsync(Guid id);

        /// <summary>
        /// Дефинира метод връщащ колекция със смените на потребител за месец указан от date        /// 
        /// </summary>
        /// <param name="userId">Идентификатор на потребител</param>
        /// <param name="date">Дата сочеща месеца за който да бъдат взети смените</param>
        /// <returns></returns>
        public Task<IList<ShiftsTransferModel>> GetUserShiftsPerPeriodAsync(Guid userId, AppDateOnly date);

        /// <summary>
        /// Дефинира метод редактиращ сменния график на потребител с идентификатор id
        /// съобразно списъка в transfer
        /// </summary>
        /// <param name="id">Идентификатор на потребител</param>
        /// <param name="period">Период</param>
        /// <param name="transfer">Списък със смени</param>
        /// <returns></returns>
		public Task<StatusModel> ModifyNewShiftsRotationAsync(Guid id, DateOnly period, List<ShiftsTransferModel> transfer);

        /// <summary>
        /// Декларация на метод зареждаща сменен график от файл
        /// </summary>
        /// <param name="file">файл с данни за смените</param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public Task<StatusModel> SetWorkingRotation(IFormFile file, string userName);
    }
}