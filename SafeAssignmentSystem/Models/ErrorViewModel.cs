namespace SafeAssignmentSystem.Models
{
    /// <summary>
    /// ����� ������������� � ������������� �� ������������� �� ������ �� ������������
    /// </summary>
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}