using Microsoft.EntityFrameworkCore;

namespace CarBMW.API.MODEL
{
    public class Dbcontext:DbContext
    {
        //依赖注入
        public Dbcontext() { }
        public Dbcontext(DbContextOptions<Dbcontext> options) : base(options) { }

        public DbSet<AllotInfo> AllotInfo { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Attribute> Attribute { get; set; }
        public DbSet<CarMessage> CarMessage { get; set; }
        public DbSet<CarSet> CarSet { get; set; }
        public DbSet<ClientMessage> ClientMessage { get; set; }
        public DbSet<ClientOrder> ClientOrder { get; set; }
        public DbSet<Commodity> Commodity { get; set; }
        public DbSet<CompanyFinance> CompanyFinance { get; set; }
        public DbSet<DepartmentInfo> DepartmentInfo { get; set; }
        public DbSet<EmployeeLeave> EmployeeLeave { get; set; }
        public DbSet<EmployeeMessage> EmployeeMessage { get; set; }
        public DbSet<EmployeeSalary> EmployeeSalary { get; set; }
        public DbSet<InWarehouesInfo> InWarehouesInfo { get; set; }
        public DbSet<MenuInfo> MenuInfo { get; set; }
        public DbSet<MyshoppingCar> MyshoppingCar { get; set; }
        public DbSet<OutWareInfo> OutWareInfo { get; set; }
        public DbSet<Property> Property { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<PurchaseDate> PurchaseDate { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
        public DbSet<RoleMenu> RoleMenu { get; set; }
        public DbSet<SignOut> SignOut { get; set; }
        public DbSet<Site> Site { get; set; }
        public DbSet<StaffSign> StaffSign { get; set; }
        public DbSet<TimeInfo> TimeInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<Wage> Wage { get; set; }
        public DbSet<WarehouesDetailInfo> WarehouesDetailInfo { get; set; }
        public DbSet<WarehouesTypeInfo> WarehouesTypeInfo { get; set; }
    }
}