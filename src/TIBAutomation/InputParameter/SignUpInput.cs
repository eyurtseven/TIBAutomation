namespace TIBAutomation.InputParameter
{
    public class SignUpInput : IInputParameter
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsApprovedAggrement { get; set; }
        public bool IsSendEmailNotification { get; set; }
    }
}
