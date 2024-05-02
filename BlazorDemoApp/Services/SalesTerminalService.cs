using BlazorDemoApp.Data;

namespace BlazorDemoApp.Services
{
    public class SalesTerminalService
    {
        public SalesTerminalService()
        {
        }

        public List<UserRole> UserRoles = new List<UserRole>
        {
            new UserRole { Name = "Reader" },
            new UserRole { Name = "Salesperson" },
        };

        public List<User> Users = new List<User>
        {
            new User
            {
                UserName = "Colin",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Salesperson" }
                }
            },
            new User
            {
                UserName = "Annee",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Salesperson" },
                    new UserRole { Name = "Reader" },
                }
            },
            new User
            {
                UserName = "Shanaaz",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Reader" }
                }
            },
            new User
            {
                UserName = "Roli",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Reader" },
                }
            },
            new User
            {
                UserName = "Margie",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Reader" },
                }
            },
            new User
            {
                UserName = "Michaela",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Salesperson" }
                }
            },
            new User
            {
                UserName = "Paula",
                Roles = new List<UserRole>
                {
                    new UserRole { Name = "Salesperson" }
                }
            }

        };

        public List<PayOutRule> PayOutRules = new List<PayOutRule>
    {
        new PayOutRule
        {
            Description = "Salesperson Sales",
            Percentage = 0.10m,
            PayThreshhold = 2000,
            PayCap = -1,
            RuleAmount = 0
        },
        new PayOutRule
        {
            Description = "Reader Sales",
            Percentage = 0.10m,
            PayThreshhold = 0,
            PayCap = -1,
            RuleAmount = 0
        },
        new PayOutRule
        {
            Description = "Readings",
            Percentage = 0.4m,
            PayThreshhold = 0,
            PayCap = -1,
            RuleAmount = 0
        },
        new PayOutRule
        {
            Description = "Salary",
            Percentage = 0.0m,
            PayThreshhold = 0,
            PayCap = -1,
            RuleAmount = 500
        }
    };
    }
}
