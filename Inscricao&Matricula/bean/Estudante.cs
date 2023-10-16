using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inscricao_Matricula.bean
{
    public class Curso
    {
        public int CursoID { get; set; }
        public string NomeCurso { get; set; }
    }

    public class Estudante
    {
        public int EstudanteID { get; set; }
        public string Faculdade { get; set; }
        public string Grau { get; set; }
        public string Turno { get; set; }
        public string NomeCurso { get; set; }
        public string Apelido { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string PaisNascimento { get; set; }
        public string ProvinciaNascimento { get; set; }
        public string LocalNascimento { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nuit { get; set; }
        public string Genero { get; set; }
        public string Celular { get; set; }
        public int CursoID { get; set; }
    }

    public class Matricula
    {
        public int MatriculaID { get; set; }
        public int EstudanteID { get; set; }
        public int CursoID { get; set; }
        public int AnoMatricula { get; set; }
    }
    public class EstudanteMatriculado
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Curso { get; set; }
        public string Faculdade { get; set; }
        public int IDMatricula { get; set; }
        public int Ano { get; set; }
    }

}
