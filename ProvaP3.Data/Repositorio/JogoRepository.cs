
using Microsoft.Extensions.Configuration;
using ProvaP3.Dominio.Entidades;
using ProvaP3.Dominio.Interfaces;
using System.Data.SqlClient;

namespace ProvaP3.Data.Repositorio
{
    public class JogoRepository : IJogoRepository
    {
        private readonly string _connectionString;

        public JogoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void Registrar(Jogo jogo)
        {
            var sql = @"INSERT INTO Jogo (Valor1, Valor2, Valor3, Valor4, Valor5, Valor6, DataJogo)
                        VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6, @DataJogo)";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Valor1", jogo.Valor1);
                cmd.Parameters.AddWithValue("@Valor2", jogo.Valor2);
                cmd.Parameters.AddWithValue("@Valor3", jogo.Valor3);
                cmd.Parameters.AddWithValue("@Valor4", jogo.Valor4);
                cmd.Parameters.AddWithValue("@Valor5", jogo.Valor5);
                cmd.Parameters.AddWithValue("@Valor6", jogo.Valor6);
                cmd.Parameters.AddWithValue("@DataJogo", jogo.DataJogo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public List<Jogo> ObterTodos()
        {
            var lista = new List<Jogo>();

            var sql = "SELECT Valor1, Valor2, Valor3, Valor4, Valor5, Valor6, DataJogo FROM Jogo";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(new Jogo(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5)
                        ));
                    }
                }
            }
            return lista;
        }
    }
}
