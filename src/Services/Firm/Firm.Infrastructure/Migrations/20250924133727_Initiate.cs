using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Firm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initiate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "firm");

            migrationBuilder.CreateTable(
                name: "Person",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Person_Person_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "firm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Conversion = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Unit_Unit_ParentId",
                        column: x => x.ParentId,
                        principalSchema: "firm",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonLocation",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonLocation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonLocation_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "firm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonPosition",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonType = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonPosition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonPosition_Person_PersonId",
                        column: x => x.PersonId,
                        principalSchema: "firm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Truck",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TruckType = table.Column<int>(type: "int", nullable: false),
                    Plate = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Truck", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Truck_Person_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "firm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Truck_Person_OwnerId",
                        column: x => x.OwnerId,
                        principalSchema: "firm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    UnitId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Unit_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "firm",
                        principalTable: "Unit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractType = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FactoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contract_PersonLocation_PersonAddressId",
                        column: x => x.PersonAddressId,
                        principalSchema: "firm",
                        principalTable: "PersonLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contract_PersonLocation_PersonLocationId",
                        column: x => x.PersonLocationId,
                        principalSchema: "firm",
                        principalTable: "PersonLocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Contract_Person_FactoryId",
                        column: x => x.FactoryId,
                        principalSchema: "firm",
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Material",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MainProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Material", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Material_Product_MainProductId",
                        column: x => x.MainProductId,
                        principalSchema: "firm",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Material_Product_SubProductId",
                        column: x => x.SubProductId,
                        principalSchema: "firm",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractDetails",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QTY_Price = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<float>(type: "real", nullable: false),
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractDetails_Contract_ContractId",
                        column: x => x.ContractId,
                        principalSchema: "firm",
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContractDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "firm",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ContractService",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TruckType = table.Column<int>(type: "int", nullable: false),
                    QTY_Price = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractService_Contract_ContractId",
                        column: x => x.ContractId,
                        principalSchema: "firm",
                        principalTable: "Contract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractLog",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractLog_ContractDetails_ContractDetailsId",
                        column: x => x.ContractDetailsId,
                        principalSchema: "firm",
                        principalTable: "ContractDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContractLogVehicle",
                schema: "firm",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullWeight = table.Column<float>(type: "real", nullable: false),
                    ContractDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TruckId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractLogVehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContractLogVehicle_ContractDetails_ContractDetailsId",
                        column: x => x.ContractDetailsId,
                        principalSchema: "firm",
                        principalTable: "ContractDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContractLogVehicle_Truck_TruckId",
                        column: x => x.TruckId,
                        principalSchema: "firm",
                        principalTable: "Truck",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contract_FactoryId",
                schema: "firm",
                table: "Contract",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_PersonAddressId",
                schema: "firm",
                table: "Contract",
                column: "PersonAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_PersonLocationId",
                schema: "firm",
                table: "Contract",
                column: "PersonLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractDetails_ContractId_ProductId",
                schema: "firm",
                table: "ContractDetails",
                columns: new[] { "ContractId", "ProductId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContractDetails_ProductId",
                schema: "firm",
                table: "ContractDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractLog_ContractDetailsId",
                schema: "firm",
                table: "ContractLog",
                column: "ContractDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractLogVehicle_ContractDetailsId_TruckId",
                schema: "firm",
                table: "ContractLogVehicle",
                columns: new[] { "ContractDetailsId", "TruckId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContractLogVehicle_TruckId",
                schema: "firm",
                table: "ContractLogVehicle",
                column: "TruckId");

            migrationBuilder.CreateIndex(
                name: "IX_ContractService_ContractId_TruckType",
                schema: "firm",
                table: "ContractService",
                columns: new[] { "ContractId", "TruckType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Material_MainProductId_SubProductId",
                schema: "firm",
                table: "Material",
                columns: new[] { "MainProductId", "SubProductId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Material_SubProductId",
                schema: "firm",
                table: "Material",
                column: "SubProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Person_ParentId",
                schema: "firm",
                table: "Person",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonLocation_PersonId",
                schema: "firm",
                table: "PersonLocation",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonPosition_PersonId_PersonType",
                schema: "firm",
                table: "PersonPosition",
                columns: new[] { "PersonId", "PersonType" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Title",
                schema: "firm",
                table: "Product",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_UnitId",
                schema: "firm",
                table: "Product",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Truck_DriverId",
                schema: "firm",
                table: "Truck",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Truck_OwnerId_DriverId_Plate",
                schema: "firm",
                table: "Truck",
                columns: new[] { "OwnerId", "DriverId", "Plate" });

            migrationBuilder.CreateIndex(
                name: "IX_Unit_ParentId",
                schema: "firm",
                table: "Unit",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Unit_Title",
                schema: "firm",
                table: "Unit",
                column: "Title",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContractLog",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "ContractLogVehicle",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "ContractService",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "Material",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "PersonPosition",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "ContractDetails",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "Truck",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "Contract",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "PersonLocation",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "Unit",
                schema: "firm");

            migrationBuilder.DropTable(
                name: "Person",
                schema: "firm");
        }
    }
}
