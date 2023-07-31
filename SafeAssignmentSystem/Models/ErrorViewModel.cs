namespace SafeAssignmentSystem.Models
{
    /// <summary>
    /// ћодел кореспондиращ с изображението за визуализиране на грешки на приложението
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}