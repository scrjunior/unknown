﻿using Inscricao_Matricula.bean;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

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

                
                
            }
        }

        public List<Estudante> SelecionarEstudantesComCurso()
        {
            List<Estudante> listaEstudantes = new List<Estudante>();

            using (var connection = conexao.AbrirConexao())
            {
                string query = "SELECT e.EstudanteID, e.Nome, e.Apelido, e.Grau, e.CursoID, c.NomeCurso AS NomeCurso, e.Faculdade " +
                               "FROM estudantes e " +
                               "INNER JOIN cursos c ON e.CursoID = c.CursoID";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Estudante estudante = new Estudante
                        {
                            EstudanteID = reader.GetInt32("EstudanteID"), // Correção aqui
                            Nome = reader.GetString("Nome"),
                            Apelido = reader.GetString("Apelido"),
                            Grau = reader.GetString("Grau"),
                            CursoID = reader.GetInt32("CursoID"),
                            NomeCurso = reader.GetString("NomeCurso"),
                            Faculdade = reader.GetString("Faculdade")
                        };

                        listaEstudantes.Add(estudante);
                    }
                }
            }

            return listaEstudantes;
        }

        public void DeletarEstudante(int estudanteID)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = "DELETE FROM estudantes WHERE EstudanteID = @EstudanteID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EstudanteID", estudanteID);

                cmd.ExecuteNonQuery();
            }
        }

        public Estudante SelecionarEstudantePorID(int estudanteID)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = "SELECT e.*, c.NomeCurso, e.DataNascimento FROM estudantes e INNER JOIN cursos c ON e.CursoID = c.CursoID WHERE e.EstudanteID = @EstudanteID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EstudanteID", estudanteID);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Estudante student = new Estudante
                        {
                            EstudanteID = reader.GetInt32("EstudanteID"),
                            Faculdade = reader.GetString("Faculdade"),
                            Grau = reader.GetString("Grau"),
                            Nome = reader.GetString("Nome"),
                            Apelido = reader.GetString("Apelido"),
                            CursoID = reader.GetInt32("CursoID"),
                            NomeCurso = reader.GetString("NomeCurso"), // Populate the course name
                            Turno = reader.GetString("Turno"),
                            PaisNascimento = reader.GetString("PaisNascimento"),
                            LocalNascimento = reader.GetString("LocalNascimento"),
                            ProvinciaNascimento = reader.GetString("ProvinciaNascimento"),
                            TipoDocumento = reader.GetString("TipoDocumento"),
                            NumeroDocumento = reader.GetString("NumeroDocumento"),
                            Nuit = reader.GetString("Nuit"),
                            Genero = reader.GetString("Genero"),
                            Celular = reader.GetString("Celular"),
                            DataNascimento = reader.GetDateTime("DataNascimento") // Include DataNascimento
                        };

                        return student;
                    }
                }

                return null; // Return null if the student is not found
            }
        }

        public void AtualizarEstudante(Estudante estudante)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = @"UPDATE estudantes 
                        SET Faculdade = @Faculdade, 
                            Grau = @Grau, 
                            Turno = @Turno, 
                            Apelido = @Apelido, 
                            Nome = @Nome, 
                            DataNascimento = @DataNascimento, 
                            PaisNascimento = @PaisNascimento, 
                            ProvinciaNascimento = @ProvinciaNascimento, 
                            LocalNascimento = @LocalNascimento, 
                            TipoDocumento = @TipoDocumento, 
                            NumeroDocumento = @NumeroDocumento, 
                            Nuit = @Nuit, 
                            Genero = @Genero, 
                            Celular = @Celular, 
                            CursoID = @CursoID 
                        WHERE EstudanteID = @EstudanteID";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EstudanteID", estudante.EstudanteID);
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
                cmd.Parameters.AddWithValue("@CursoID", estudante.CursoID);

                cmd.ExecuteNonQuery();
            }
        }

        public void MatricularEstudante(int estudanteID, int cursoID, int anoMatricula)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = @"INSERT INTO matriculas (EstudanteID, CursoID, AnoMatricula) 
                         VALUES (@EstudanteID, @CursoID, @AnoMatricula)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EstudanteID", estudanteID);
                cmd.Parameters.AddWithValue("@CursoID", cursoID);
                cmd.Parameters.AddWithValue("@AnoMatricula", anoMatricula);

                cmd.ExecuteNonQuery();
            }
        }

        public bool VerificarMatriculaExistente(int estudanteID, int cursoID)
        {
            using (var connection = conexao.AbrirConexao())
            {
                string query = "SELECT COUNT(*) FROM matriculas WHERE EstudanteID = @EstudanteID AND CursoID = @CursoID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@EstudanteID", estudanteID);
                cmd.Parameters.AddWithValue("@CursoID", cursoID);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                return count > 0; // Retorna true se a matrícula existir, caso contrário, retorna false
            }
        }

    }
}
