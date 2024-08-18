using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

public class Database
{
    private string connectionString;

    public Database()
    {
        connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
    }

    public MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }

    public DataTable ExecuteQuery(string query)
    {
        using (MySqlConnection conn = GetConnection())
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }

    public int ExecuteNonQuery(string query)
    {
        using (MySqlConnection conn = GetConnection())
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            return cmd.ExecuteNonQuery();
        }
    }

    public void CreateTables()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string createDatabaseQuery = "CREATE DATABASE IF NOT EXISTS escola;";
            MySqlCommand cmdCreateDb = new MySqlCommand(createDatabaseQuery, conn);
            cmdCreateDb.ExecuteNonQuery();

            string useDatabaseQuery = "USE escola;";
            MySqlCommand cmdUseDb = new MySqlCommand(useDatabaseQuery, conn);
            cmdUseDb.ExecuteNonQuery();

            string createTablesQuery = @"
                CREATE TABLE IF NOT EXISTS tb_aluno (
                    matricula_aluno int NOT NULL AUTO_INCREMENT,
                    nome_aluno varchar(100) NOT NULL,
                    email_aluno varchar(45) NOT NULL,
                    telefone_aluno varchar(20) DEFAULT NULL,
                    senha_aluno varchar(50) NOT NULL,
                    endereco_aluno varchar(100) DEFAULT NULL,
                    cidade_aluno varchar(100) NOT NULL,
                    data_nasc_aluno varchar(10) DEFAULT NULL,
                    PRIMARY KEY (matricula_aluno)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_curso (
                    id_curso int NOT NULL AUTO_INCREMENT,
                    nome_curso varchar(100) NOT NULL,
                    duracao int DEFAULT '4',
                    PRIMARY KEY (id_curso)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_disciplina (
                    id_disciplina int NOT NULL AUTO_INCREMENT,
                    disciplina varchar(100) NOT NULL,
                    habilidades varchar(200) DEFAULT NULL,
                    PRIMARY KEY (id_disciplina)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_professor (
                    id_professor int NOT NULL AUTO_INCREMENT,
                    nome_professor varchar(100) DEFAULT NULL,
                    formacao varchar(100) DEFAULT NULL,
                    titulacao varchar(100) DEFAULT NULL,
                    email_professor varchar(45) DEFAULT NULL,
                    senha_professor varchar(50) NOT NULL,
                    PRIMARY KEY (id_professor)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_curso_disciplina (
                    id_curso int NOT NULL,
                    id_disciplina int NOT NULL,
                    PRIMARY KEY (id_curso, id_disciplina),
                    FOREIGN KEY (id_curso) REFERENCES tb_curso(id_curso),
                    FOREIGN KEY (id_disciplina) REFERENCES tb_disciplina(id_disciplina)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_curso_professor (
                    id_curso int NOT NULL,
                    id_professor int NOT NULL,
                    PRIMARY KEY (id_curso, id_professor),
                    FOREIGN KEY (id_curso) REFERENCES tb_curso(id_curso),
                    FOREIGN KEY (id_professor) REFERENCES tb_professor(id_professor)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

                CREATE TABLE IF NOT EXISTS tb_curso_aluno (
                    id_curso int NOT NULL,
                    matricula_aluno int NOT NULL,
                    PRIMARY KEY (id_curso, matricula_aluno),
                    FOREIGN KEY (id_curso) REFERENCES tb_curso(id_curso),
                    FOREIGN KEY (matricula_aluno) REFERENCES tb_aluno(matricula_aluno)
                ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
            ";

            MySqlCommand cmdCreateTables = new MySqlCommand(createTablesQuery, conn);
            cmdCreateTables.ExecuteNonQuery();

            conn.Close();
        }
    }

    public DataTable BuscarDisciplinas()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;

        }
    }

    public DataTable BuscarDisciplinaPorId(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina WHERE id_disciplina = @id_disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_disciplina", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }
    public DataTable BuscarDisciplinaPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection()) {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina WHERE disciplina LIKE @nome_disciplina";
            MySqlCommand cmd= new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_disciplina", "%" + nome + "%");

            MySqlDataAdapter adapter= new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public DataTable BuscarDisciplinaPorHabilidade(String habilidade)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina WHERE habilidades LIKE @habilidade";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@habilidade", "%" + habilidade + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public DataTable BuscarDisciplina(String nome, int id, String habilidade)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina WHERE id = @id_disciplina AND disciplina LIKE @nome_disciplina AND habilidades ILIKE @habilidade";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_disciplina", id);
            cmd.Parameters.AddWithValue("@nome_disciplina", nome);
            cmd.Parameters.AddWithValue("@habilidade", "%" + habilidade + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public bool verificarLoginAluno(string usuario, string senha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tb_aluno WHERE nome_aluno = @usuario AND senha_aluno = @senha";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }

    public bool verificarLoginProfessor(string usuario, string senha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tb_professor WHERE nome_professor = @usuario AND senha_professor = @senha";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }

    public bool verificarNomeEmailAluno(string usuario, string email)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tb_aluno WHERE nome_aluno = @usuario AND email_aluno = @email";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@email", email);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }

    public bool verificarNomeEmailProfessor(string usuario, string email)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tb_professor WHERE nome_professor = @usuario AND email_professor = @email";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@email", email);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }

    public bool mudarSenhaAluno(String email, string novaSenha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query = "UPDATE tb_aluno SET senha_aluno = @novaSenha WHERE email_aluno = @email";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@novaSenha", novaSenha);
                cmd.Parameters.AddWithValue("@email", email);

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0;
            }
        }
    }

    public bool mudarSenhaProfessor(String email, string novaSenha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            string query = "UPDATE tb_professor SET senha_professor = @novaSenha WHERE email_professor = @email";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@novaSenha", novaSenha);
                cmd.Parameters.AddWithValue("@email", email);

                int resultado = cmd.ExecuteNonQuery();

                return resultado > 0;
            }
        }
    }

    public void cadastrarAluno(String nome, String email, String senha, String telefone, String data_nasc, String cidade, String endereco)
    {
        using(MySqlConnection conn = GetConnection())
        {
            conn.Open();

            String query= "INSERT INTO tb_aluno (nome_aluno, email_aluno, senha_aluno, telefone_aluno, data_nasc_aluno, cidade_aluno, endereco) VALUES (@nome, @email, @senha, @telefone, @data_nascimento, @cidade, @endereco)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@data_nascimento", data_nasc);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }

    public void cadastrarProfessor(String nome, String email, String senha, String formacao, String titulacao)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            String query = "INSERT INTO tb_professor (nome_professor, email_professor, senha_professor, formacao, titulacao) VALUES (@nome, @email, @senha, @formacao, @titulacao)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@formacao", formacao);
            cmd.Parameters.AddWithValue("@titulacao", titulacao);
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }

    public List<string> BuscarNomeIdDisciplinas()
    {
        List<string> disciplinas = new List<string>();

        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT id_disciplina, disciplina FROM tb_disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = reader.GetInt32("id_disciplina");
                    string nome = reader.GetString("disciplina");
                    disciplinas.Add($"id: {id}, disciplina: {nome}");
                }
            }

            conn.Close();
        }

        return disciplinas;
    }

    public void CadastrarCurso(string nomeCurso, String duracao)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO tb_curso (nome_curso, duracao) VALUES (@nomeCurso, @duracao)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nomeCurso", nomeCurso);
            cmd.Parameters.AddWithValue("@duracao", duracao);

            cmd.ExecuteNonQuery();
        }
    }

    public int BuscarIdCursoPorNome(string nomeCurso)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT id_curso FROM tb_curso WHERE nome_curso = @nomeCurso";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nomeCurso", nomeCurso);

            object result = cmd.ExecuteScalar();
      
            return Convert.ToInt32(result);
        }
    }

    public void AtrelarDisciplinasAoCurso(int idCurso, int idDisciplina)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO tb_curso_disciplina (id_curso, id_disciplina) VALUES (@idCurso, @idDisciplina)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idCurso", idCurso);
            cmd.Parameters.AddWithValue("@idDisciplina", idDisciplina);

            cmd.ExecuteNonQuery();
        }
    }

    public void CadastrarDisciplina(String disciplina, String habilidades)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO tb_disciplina (disciplina, habilidades) VALUES (@disciplina, @habilidades)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@disciplina", disciplina);
            cmd.Parameters.AddWithValue("@hbailidades", habilidades);

            cmd.ExecuteNonQuery();
        }
    }

    public void InscreverSeCurso(int idAluno, int idCurso)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO tb_curso_aluno (id_curso, matricula_aluno) VALUES (@idCurso, @idAluno)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@idCurso", idCurso);
            cmd.Parameters.AddWithValue("@idAluno", idAluno);

            cmd.ExecuteNonQuery();
        }
    }

    public DataTable BuscarCursos()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_curso";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;

        }
    }

    public DataTable BuscarCursoPorId(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_curso WHERE id_curso = @id_curso";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_curso", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public DataTable BuscarCursoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_curso WHERE nome_curso LIKE @nome_curso";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_curso", "%" + nome + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public DataTable BuscarCursoPorDisciplina(String disciplina)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_curso WHERE disciplina LIKE @disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@disciplina", "%" + disciplina + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public DataTable BuscarCurso(String nome, int id, String disciplina)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_curso WHERE id = @id_curso AND nome_curso LIKE @nome_curso AND disciplina ILIKE @disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_curso", id);
            cmd.Parameters.AddWithValue("@nome_curso", nome);
            cmd.Parameters.AddWithValue("@disciplina", "%" + disciplina + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public int BuscarIdProfessorPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT id_professor FROM tb_professor WHERE nome_professor = @nome_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_professor", nome);

            object result = cmd.ExecuteScalar();

            return Convert.ToInt32(result);
        }
    }

    public DataTable BuscarDisciplinasProfessorPorId(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"
            SELECT d.id_disciplina, d.nome_disciplina
            FROM tb_curso_disciplina cd
            JOIN tb_disciplina d ON cd.id_disciplina = d.id_disciplina
            JOIN tb_curso_professor cp ON cd.id_curso = cp.id_curso
            WHERE cp.id_professor = @id_professor";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_professor", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public DataTable BuscarCursosProfessorPorId(int id)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"
            SELECT c.id_curso, c.nome_curso
            FROM tb_curso_professor cp
            JOIN tb_curso c ON cp.id_curso = c.id_curso
            WHERE cp.id_professor = @id_professor";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_professor", id);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            conn.Close();

            return dt;
        }
    }

    public String ObterTitulacaoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT titulacao FROM tb_professor WHERE nome_professor = @nome_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_professor", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarEmailProfessorPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT email_professor FROM tb_professor WHERE nome_professor = @nome_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_professor", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarFormacaoProfessorPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT formacao FROM tb_professor WHERE nome_professor = @nome_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_professor", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarSenhaProfessorPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT senha_professor FROM tb_professor WHERE nome_professor = @nome_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_professor", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarTitulacaoProfessorPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT titulacao FROM tb_professor WHERE nome_professor = @nome_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_professor", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public void AtualizarEmailProfessor(String nome, String email)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_professor SET email_professor = @email WHERE nome_professor = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarSenhaProfessor(String nome, String senha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_professor SET senha_professor = @senha WHERE nome_professor = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarFormacaoProfessor(String nome, String formacao)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_professor SET formacao = @formacao WHERE nome_professor = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@formacao", formacao);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarTitulacaoProfessor(String nome, String titulacao)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_professor SET titulacao = @titulacao WHERE nome_professor = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@titulacao", titulacao);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarProfessor(String nome, String email, String senha, String formacao, String titulacao)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_professor SET email_professor = @email, senha_professor = @senha, formacao = @formacao, titulacao = @titulacao WHERE nome_professor = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@formacao", formacao);
            cmd.Parameters.AddWithValue("@titulacao", titulacao);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public String BuscarEmailAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT email_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarSenhaAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT senha_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarTelefoneAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT telefone_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarCidadeAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT cidade_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public String BuscarEnderecoAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT endereco_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    public DateTime BuscarDataNascAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT data_nasc_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return (DateTime)result;
        }
    }

    public void AtualizarEmailAluno(String nome, String email)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET email_aluno = @email WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarSenhaAluno(String nome, String senha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET senha_aluno = @senha WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarTelefoneAluno(String nome, String telefone)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET telefone_aluno = @telefone WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarCidadeAluno(String nome, String cidade)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET cidade_aluno = @cidade WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarEnderecoAluno(String nome, String endereco)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET endereco_aluno = @endereco WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarDataNascAluno(String nome, String dataNasc)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET data_nasc_aluno = @data_nasc WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }

    public void AtualizarAluno(String nome, String email, String senha, String telefone, String cidade, String endereco, String dataNasc)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "UPDATE tb_aluno SET email_aluno = @email, senha_aluno = @senha, telefone_aluno = @telefone, cidade_aluno = @cidade, endereco_aluno = @endereco, data_nasc_aluno = @data_nasc WHERE nome_aluno = @nome";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            cmd.Parameters.AddWithValue("@telefone", telefone);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@endereco", endereco);
            cmd.Parameters.AddWithValue("@data_nasc", dataNasc);
            cmd.Parameters.AddWithValue("@nome", nome);

            cmd.ExecuteNonQuery();
        }
    }
}
