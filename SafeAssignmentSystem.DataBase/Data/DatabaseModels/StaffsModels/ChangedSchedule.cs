namespace SafeAssignmentSystem.DataBase.Data.DatabaseModels.StaffsModels
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using SafeAssignmentSystem.DataBase.Data.DatabaseModels.Account;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Модел на сменния график
    /// </summary>
    [Comment("Модел на сменния график")]
    public class ChangedSchedule
    {
        /// <summary>
        /// Дата
        /// </summary>
        [Comment("Дата")]
        [Required]
        public DateTime Date { get; set; }

        /// <summary>
        /// Id на потребител който е на смяна(оператор или дежурен електромонтьор)
        /// </summary>
        [Comment("Id на потребител който е на смяна(оператор или дежурен електромонтьор)")]
        [Required]
        [ForeignKey(nameof(ApplicationUser))]
        public Guid ApplicationUserId { get; set; }

        /// <summary>
        /// Кореспондиращо поле сочещо към потребител
        /// </summary>
        [Comment("Кореспондиращо поле сочещо към потребител")]
        [Required]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        /// <summary>
        /// Id на смяна
        /// </summary>
        [Comment("Id на смяна")]
        [Required]
        [ForeignKey(nameof(Shift))]
        public Guid ShiftId { get; set; }

        /// <summary>
        /// Кореспондиращо поле сочещо към смяна
        /// </summary>
        [Comment("Кореспондиращо поле сочещо към смяна")]
        [Required]
        public virtual WorkingShift Shift { get; set; } = null!;
    }
}
