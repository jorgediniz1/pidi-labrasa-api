using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labrasa.API.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_funcionarios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_funcionarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_mesas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numero_mesa = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    comandas_abertas = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    comandas_fechadas = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_mesas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_produtos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    produtos = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    categoria = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    quantidade_estoque = table.Column<decimal>(type: "numeric", nullable: false),
                    quantidade_minima = table.Column<decimal>(type: "numeric", nullable: false),
                    preco_custo = table.Column<decimal>(type: "numeric(38,2)", nullable: false),
                    preco_venda = table.Column<decimal>(type: "numeric(38,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produtos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_comandas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorTotal = table.Column<decimal>(type: "numeric(38,2)", nullable: false),
                    DataHoraAbertura = table.Column<DateTime>(type: "datetime", nullable: false),
                    DataHoraFechamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    StatusComanda = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: false),
                    FuncionarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_comandas", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_comandas_tb_funcionarios_FuncionarioId",
                        column: x => x.FuncionarioId,
                        principalTable: "tb_funcionarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_comandas_tb_mesas_MesaId",
                        column: x => x.MesaId,
                        principalTable: "tb_mesas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_pedidos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_pedido = table.Column<DateTime>(type: "date", nullable: false),
                    valor_pedido = table.Column<decimal>(type: "money", nullable: false),
                    ComandaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_pedidos", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_pedidos_tb_comandas_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "tb_comandas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_produto_pedido",
                columns: table => new
                {
                    pedido_id = table.Column<int>(type: "int", nullable: false),
                    produto_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto_pedido", x => new { x.produto_id, x.pedido_id });
                    table.ForeignKey(
                        name: "FK_tb_produto_pedido_tb_pedidos_pedido_id",
                        column: x => x.pedido_id,
                        principalTable: "tb_pedidos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_produto_pedido_tb_produtos_produto_id",
                        column: x => x.produto_id,
                        principalTable: "tb_produtos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_comandas_FuncionarioId",
                table: "tb_comandas",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_comandas_MesaId",
                table: "tb_comandas",
                column: "MesaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_pedidos_ComandaId",
                table: "tb_pedidos",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_pedido_pedido_id",
                table: "tb_produto_pedido",
                column: "pedido_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_produto_pedido");

            migrationBuilder.DropTable(
                name: "tb_pedidos");

            migrationBuilder.DropTable(
                name: "tb_produtos");

            migrationBuilder.DropTable(
                name: "tb_comandas");

            migrationBuilder.DropTable(
                name: "tb_funcionarios");

            migrationBuilder.DropTable(
                name: "tb_mesas");
        }
    }
}
