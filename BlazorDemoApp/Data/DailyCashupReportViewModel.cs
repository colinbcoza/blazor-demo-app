namespace BlazorDemoApp.Data
{
    public class CashierShiftReport
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public User Cashier { get; set; } = new User();
        public DateTime ShiftStart { get; set; } = DateTime.Now;
        public DateTime ShiftEnd { get; set; } = DateTime.Now;
        public decimal TotalCash { get; set; } = 0;
        public decimal TotalCard { get; set; } = 0;
        public decimal TotalEft { get; set; } = 0;
        public List<StaffShift> StaffShifts { get; set; } = new List<StaffShift>();
    }

    public class StaffShift
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public User SalesPerson { get; set; } = new User();
        public UserRole Role { get; set; } = new UserRole();
        public decimal TotalPayout { get; set; } = 0;
        public List<StaffShiftPay> StaffShiftPays { get; set; } = new List<StaffShiftPay>();
    }

    public class StaffShiftPay
    {
        public decimal Turnover { get; set; } = 0;
        public PayOutRule Rule { get; set; } = new PayOutRule();
        public decimal Payout { get; set; } = 0;
    }

    public class PayOutRule
    {
        public string Description { get; set; } = string.Empty;
        public decimal Percentage { get; set; } = 0;
        public decimal PayThreshhold { get; set; } = 0;
        public decimal PayCap { get; set; } = 0;
        public decimal RuleAmount { get; set; } = 0;
    }

    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string UserName { get; set; } = string.Empty;
        public List<UserRole> Roles { get; set; } = new List<UserRole>();
    }

    public class UserRole
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
    }

    public class DailyCashupReportViewModel
    {
    }
}
