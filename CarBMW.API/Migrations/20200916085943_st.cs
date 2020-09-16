using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarBMW.API.Migrations
{
    public partial class st : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllotInfo",
                columns: table => new
                {
                    Awid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeMessageid = table.Column<int>(nullable: false),
                    Departmentid = table.Column<int>(nullable: false),
                    ASignTimes = table.Column<int>(nullable: false),
                    AWithdrawalTimes = table.Column<int>(nullable: false),
                    ALeaveTimes = table.Column<int>(nullable: false),
                    Acategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllotInfo", x => x.Awid);
                });

            migrationBuilder.CreateTable(
                name: "Attendance",
                columns: table => new
                {
                    Acwaid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeMessageid = table.Column<int>(nullable: false),
                    Departmentid = table.Column<int>(nullable: false),
                    ASignTimes = table.Column<int>(nullable: false),
                    AWithdrawalTimes = table.Column<int>(nullable: false),
                    ALeaveTimes = table.Column<int>(nullable: false),
                    Acategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance", x => x.Acwaid);
                });

            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    Caid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Commodityid = table.Column<int>(nullable: false),
                    Atid = table.Column<int>(nullable: false),
                    PropertyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Caid);
                });

            migrationBuilder.CreateTable(
                name: "CarMessage",
                columns: table => new
                {
                    Iid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cid = table.Column<int>(nullable: false),
                    COlour = table.Column<string>(nullable: true),
                    Clientid = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CWarehouseTypeid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMessage", x => x.Iid);
                });

            migrationBuilder.CreateTable(
                name: "CarSet",
                columns: table => new
                {
                    Cid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Series = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarSet", x => x.Cid);
                });

            migrationBuilder.CreateTable(
                name: "ClientMessage",
                columns: table => new
                {
                    Clientid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientSex = table.Column<int>(nullable: false),
                    ClientName = table.Column<string>(nullable: true),
                    Clientphone = table.Column<int>(nullable: false),
                    ClientCard = table.Column<string>(nullable: true),
                    ClientAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientMessage", x => x.Clientid);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrder",
                columns: table => new
                {
                    COid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientMessageid = table.Column<int>(nullable: false),
                    CarMessageid = table.Column<int>(nullable: false),
                    Ordertime = table.Column<DateTime>(nullable: false),
                    ClientPrice = table.Column<float>(nullable: false),
                    OrderSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrder", x => x.COid);
                });

            migrationBuilder.CreateTable(
                name: "Commodity",
                columns: table => new
                {
                    Cmid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stock = table.Column<int>(nullable: false),
                    CommName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commodity", x => x.Cmid);
                });

            migrationBuilder.CreateTable(
                name: "CompanyFinance",
                columns: table => new
                {
                    CFid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CFName = table.Column<string>(nullable: true),
                    Cfzprice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyFinance", x => x.CFid);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentInfo",
                columns: table => new
                {
                    DIid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentInfo", x => x.DIid);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLeave",
                columns: table => new
                {
                    ELid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeMessageid = table.Column<int>(nullable: false),
                    ReasonsLeave = table.Column<string>(nullable: true),
                    ELStartDate = table.Column<DateTime>(nullable: false),
                    ELEndTime = table.Column<DateTime>(nullable: false),
                    LeaveStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLeave", x => x.ELid);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeMessage",
                columns: table => new
                {
                    Emid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMCode = table.Column<string>(nullable: true),
                    Departmentid = table.Column<int>(nullable: false),
                    EMName = table.Column<string>(nullable: true),
                    Emsex = table.Column<bool>(nullable: false),
                    Emage = table.Column<int>(nullable: false),
                    EMCard = table.Column<string>(nullable: true),
                    Emphone = table.Column<int>(nullable: false),
                    EMAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeMessage", x => x.Emid);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSalary",
                columns: table => new
                {
                    Esid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeMessageid = table.Column<int>(nullable: false),
                    ClientMessageid = table.Column<int>(nullable: false),
                    ClientOrderid = table.Column<int>(nullable: false),
                    Wageid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalary", x => x.Esid);
                });

            migrationBuilder.CreateTable(
                name: "InWarehouesInfo",
                columns: table => new
                {
                    Iid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InWarecode = table.Column<int>(nullable: false),
                    CKid = table.Column<int>(nullable: false),
                    CarMessageid = table.Column<int>(nullable: false),
                    CarSetid = table.Column<int>(nullable: false),
                    Iinum = table.Column<int>(nullable: false),
                    Rktime = table.Column<DateTime>(nullable: false),
                    IISale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InWarehouesInfo", x => x.Iid);
                });

            migrationBuilder.CreateTable(
                name: "MenuInfo",
                columns: table => new
                {
                    Menuid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuInfo", x => x.Menuid);
                });

            migrationBuilder.CreateTable(
                name: "MyshoppingCar",
                columns: table => new
                {
                    Sid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyName = table.Column<string>(nullable: true),
                    ComColour = table.Column<string>(nullable: true),
                    CommodityPrice = table.Column<int>(nullable: false),
                    CarName = table.Column<string>(nullable: true),
                    CarType = table.Column<string>(nullable: true),
                    CarConfigure = table.Column<string>(nullable: true),
                    Uid = table.Column<int>(nullable: false),
                    AddDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyshoppingCar", x => x.Sid);
                });

            migrationBuilder.CreateTable(
                name: "OutWareInfo",
                columns: table => new
                {
                    OIid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OIcode = table.Column<string>(nullable: true),
                    CKid = table.Column<int>(nullable: false),
                    CarMessageid = table.Column<int>(nullable: false),
                    CarSetid = table.Column<int>(nullable: false),
                    Iinum = table.Column<int>(nullable: false),
                    CKtime = table.Column<DateTime>(nullable: false),
                    OISale = table.Column<int>(nullable: false),
                    CWarehouesid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutWareInfo", x => x.OIid);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    Atid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttriBute = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.Atid);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Prid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PName = table.Column<string>(nullable: true),
                    Sbid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Prid);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseDate",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarSetid = table.Column<int>(nullable: false),
                    Colour = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    PurchasDate = table.Column<DateTime>(nullable: false),
                    QualityTesting = table.Column<int>(nullable: false),
                    Wdid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseDate", x => x.Pid);
                });

            migrationBuilder.CreateTable(
                name: "RoleInfo",
                columns: table => new
                {
                    Roleid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleInfo", x => x.Roleid);
                });

            migrationBuilder.CreateTable(
                name: "RoleMenu",
                columns: table => new
                {
                    Rmid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Roleid = table.Column<int>(nullable: false),
                    MenuInfoid = table.Column<int>(nullable: false),
                    RMSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleMenu", x => x.Rmid);
                });

            migrationBuilder.CreateTable(
                name: "SignOut",
                columns: table => new
                {
                    SOEmtid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SOCheckTime = table.Column<DateTime>(nullable: false),
                    SOEmid = table.Column<int>(nullable: false),
                    SOWithStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignOut", x => x.SOEmtid);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Adid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpecificAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Adid);
                });

            migrationBuilder.CreateTable(
                name: "StaffSign",
                columns: table => new
                {
                    Sempid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Semid = table.Column<int>(nullable: false),
                    SCheckTime = table.Column<DateTime>(nullable: false),
                    SCheckStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffSign", x => x.Sempid);
                });

            migrationBuilder.CreateTable(
                name: "TimeInfo",
                columns: table => new
                {
                    Timeid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeName = table.Column<string>(nullable: true),
                    QDtime = table.Column<DateTime>(nullable: false),
                    SBtime = table.Column<DateTime>(nullable: false),
                    QTtime = table.Column<DateTime>(nullable: false),
                    XBtime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeInfo", x => x.Timeid);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    Uid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    UserPwd = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Urid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserInfoid = table.Column<int>(nullable: false),
                    RoleInfoid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Urid);
                });

            migrationBuilder.CreateTable(
                name: "Wage",
                columns: table => new
                {
                    Wageid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wages = table.Column<float>(nullable: false),
                    Emid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wage", x => x.Wageid);
                });

            migrationBuilder.CreateTable(
                name: "WarehouesDetailInfo",
                columns: table => new
                {
                    Wdid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseTypeInfoid = table.Column<int>(nullable: false),
                    CarMessageid = table.Column<int>(nullable: false),
                    CarSetid = table.Column<int>(nullable: false),
                    WDnum = table.Column<int>(nullable: false),
                    WDSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouesDetailInfo", x => x.Wdid);
                });

            migrationBuilder.CreateTable(
                name: "WarehouesTypeInfo",
                columns: table => new
                {
                    WTid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WTName = table.Column<string>(nullable: true),
                    Wtcapacity = table.Column<int>(nullable: false),
                    WTSale = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouesTypeInfo", x => x.WTid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllotInfo");

            migrationBuilder.DropTable(
                name: "Attendance");

            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "CarMessage");

            migrationBuilder.DropTable(
                name: "CarSet");

            migrationBuilder.DropTable(
                name: "ClientMessage");

            migrationBuilder.DropTable(
                name: "ClientOrder");

            migrationBuilder.DropTable(
                name: "Commodity");

            migrationBuilder.DropTable(
                name: "CompanyFinance");

            migrationBuilder.DropTable(
                name: "DepartmentInfo");

            migrationBuilder.DropTable(
                name: "EmployeeLeave");

            migrationBuilder.DropTable(
                name: "EmployeeMessage");

            migrationBuilder.DropTable(
                name: "EmployeeSalary");

            migrationBuilder.DropTable(
                name: "InWarehouesInfo");

            migrationBuilder.DropTable(
                name: "MenuInfo");

            migrationBuilder.DropTable(
                name: "MyshoppingCar");

            migrationBuilder.DropTable(
                name: "OutWareInfo");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "PurchaseDate");

            migrationBuilder.DropTable(
                name: "RoleInfo");

            migrationBuilder.DropTable(
                name: "RoleMenu");

            migrationBuilder.DropTable(
                name: "SignOut");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "StaffSign");

            migrationBuilder.DropTable(
                name: "TimeInfo");

            migrationBuilder.DropTable(
                name: "UserInfo");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Wage");

            migrationBuilder.DropTable(
                name: "WarehouesDetailInfo");

            migrationBuilder.DropTable(
                name: "WarehouesTypeInfo");
        }
    }
}
