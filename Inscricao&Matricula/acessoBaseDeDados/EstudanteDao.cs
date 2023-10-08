using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;

namespace Inscricao_Matricula.acessoBaseDeDados
{
    internal class EstudanteDao
    {
        private Conexao conexao;

        public EstudanteDao()
        {
            conexao = new Conexao();
        }

        public void InserirEstudante(Estudante estudante, int cursoID)

        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO estudantes 
                                 (Faculdade, Grau, Turno, Apelido, Nome, DataNascimento, PaisNascimento, 
                                  ProvinciaNascimento, LocalNascimento, TipoDocumento, NumeroDocumento, Nuit, 
                                  Genero, Celular, CursoID) 
                                 VALUES 
                                 (@Faculdade, @Grau, @Turno, @Apelido, @Nome, @DataNascimento, @PaisNascimento, 
                                  @ProvinciaNascimento, @LocalNascimento, @TipoDocumento, @NumeroDocumento, @Nuit, 
                                  @Genero, @Celular, @CursoID);
                                 SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Faculdade", estudante.Faculdade);
                cmd.Parameters.AddWithValue("@Grau", estudante.Grau);
                cmd.Parameters.AddWithValue("@Turno", estudante.Turno);
                cmd.Parameters.AddWithValue("@Apelido", estudante.Apelido);
                cmd.Parameters.AddWithValue("@Nome", estudante.Nome);
                cmd.Parameters.AddWithValue("@DataNascimento", estudante.DataNascimento);
                cmd.Parameters.AddWithValue("@PaisNascimento", estudante.PaisNascimento);
                cmd.Parameters.AddWithValue("@ProvinciaNascimento", estudante.ProvinciaNascimento);
                cmd.Parameters.AddWithValue("@LocalNascimento", estudante.LocalNascimento);
                cmd.Parameters.AddWithValue("@TipoDocumento", estudante.TipoDocumento);
                cmd.Parameters.AddWithValue("@NumeroDocumento", estudante.NumeroDocumento);
                cmd.Parameters.AddWithValue("@Nuit", estudante.Nuit);
                cmd.Parameters.AddWithValue("@Genero", estudante.Genero);
                cmd.Parameters.AddWithValue("@Celular", estudante.Celular);
                cmd.Parameters.AddWithValue("@CursoID", cursoID);

                int estudanteID = Convert.ToInt32(cmd.ExecuteScalar());

                // Atualizar o CursoID do estudante com o curso fornecido
                AtualizarCursoEstudante(estudanteID, cursoID);
            }
        }

        private void AtualizarCursoEstudante(int estudanteID, int cursoID)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string updateQuery = @"UPDATE estudantes 
                                      SET CursoID = @CursoID 
                                      WHERE EstudanteID = @EstudanteID";

                MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                cmd.Parameters.AddWithValue("@CursoID", cursoID);
                cmd.Parameters.AddWithValue("@EstudanteID", estudanteID);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
