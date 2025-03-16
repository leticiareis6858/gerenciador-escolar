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

    // Criar tabelas:
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

    // Buscar Disciplinas
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

    public DataTable BuscarDisciplinaPorId(String id)
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
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina WHERE disciplina LIKE @nome_disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_disciplina", "%" + nome + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
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

    // Login Aluno
    public bool verificarLoginAluno(string email, string senha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tb_aluno WHERE email_aluno = @email AND senha_aluno = @senha";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }

    // Login Professor
    public bool verificarLoginProfessor(string email, string senha)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tb_professor WHERE email_professor = @email AND senha_professor = @senha";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            conn.Close();

            return count > 0;
        }
    }

    // Buscar e verificar nome por email Aluno e Professor
    public String BuscarNomePorEmailAluno(string email)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT nome_aluno FROM tb_aluno WHERE email_aluno = @email";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }
    public String BuscarNomePorEmailProfessor(string email)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT nome_professor FROM tb_professor WHERE email_professor = @email";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            object result = cmd.ExecuteScalar();

            return result.ToString();
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

    // Mudar Senha Aluno e Professor
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

    // Cadastrar aluno e professor
    public void cadastrarAluno(String nome, String email, String senha, String telefone, String data_nasc, String cidade, String endereco)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();

            String query = "INSERT INTO tb_aluno (nome_aluno, email_aluno, senha_aluno, telefone_aluno, data_nasc_aluno, cidade_aluno, endereco_aluno) VALUES (@nome, @email, @senha, @telefone, @data_nascimento, @cidade, @endereco)";
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

    // Buscar nome e id disciplinas
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

    // Cadastrar curso
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

    // Buscar id do curso por nome
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

    // Atrelar disciplinas a um curso
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

    // Cadastrar disciplina
    public void CadastrarDisciplina(String disciplina, String habilidades)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "INSERT INTO tb_disciplina (disciplina, habilidades) VALUES (@disciplina, @habilidades)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@disciplina", disciplina);
            cmd.Parameters.AddWithValue("@habilidades", habilidades);

            cmd.ExecuteNonQuery();
        }
    }

    // Atrelar aluno a um curso
    public void InscreverSeCurso(String idAluno, String idCurso)
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

    // Buscar cursos
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

    // Buscar curso por id
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

    // Buscar curso por nome
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

    // Buscar curso por disciplina
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

    // Buscar curso por nome, id e disciplina
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

    // Buscar id de um professor através do seu nome
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

    // Buscar id e nome das disciplinas de um professor através de seu id
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

    //  Buscar id e nome dos cursos de um professor através de seu id
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

    // Buscar email de um professor através do seu nome
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

    // Buscar formação de um professor através do seu nome
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

    // Buscar senha de um professor pelo seu nome
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

    // Buscar titulação de um professor pelo seu nome
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

    // Atualizar email de um professor através do seu noem
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

    // Atualizar senha de um professor pelo seu nome
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

    // Atualizar formação de um professor pelo seu nome
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

    // Atualizar titulação de um professor pelo seu nome
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

    // Atualizar cadastro de professor pelo seu nome
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

    // Buscar email de um aluno pelo seu nome
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

    // Buscar senha de um aluno pelo seu nome
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

    // Buscar telefone de um aluno pelo seu nome
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

    // Buscar cidade de um aluno pelo seu nome
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

    // Buscar endereço de um aluno pelo seu nome
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

    // Buscar data de nascimento de um aluno pelo seu nome
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

    // Atualizar email de um aluno pelo seu nome
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

    // Atualizar senha de um aluno pelo seu nome
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

    // Atualizar telefone de um aluno pelo seu nome
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

    // Atualizar cidade de um aluno pelo seu nome
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

    // Atualizar endereço de um aluno pelo seu nome
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

    // Atualizar data de nascimento de um aluno pelo seu nome
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

    // Atualizar cadastro de um aluno pelo seu nome
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

    // Buscar id de um aluno pelo seu nome
    public String BuscarIdAlunoPorNome(String nome)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT matricula_aluno FROM tb_aluno WHERE nome_aluno = @nome_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_aluno", nome);

            object result = cmd.ExecuteScalar();

            return result.ToString();
        }
    }

    // Buscar cursos de um aluno pelo seu id
    public DataTable BuscarCursoDeAlunoPorId(int idCurso, String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"SELECT tb_curso,* FROM tb_curso_aluno INNER JOIN tb_curso ON tb_curso_aluno.id_curso = tb_curso.id_curso WHERE tb_curso_aluno.id_curso = @id_curso AND tb_curso_aluno.matricula_aluno = @id_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_curso", idCurso);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar cursos de um aluno pelo seu nome
    public DataTable BuscarCursoDeAlunoPorNome(String nomeCurso, String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"SELECT tb_curso,* FROM tb_curso_aluno INNER JOIN tb_curso ON tb_curso_aluno.id_curso = tb_curso.id_curso WHERE tb_curso.nome_curso LIKE @nome_curso AND tb_curso_aluno.matricula_aluno = @id_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_curso", nomeCurso);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar disciplinas de um aluno pelo seu id
    public DataTable BuscarDisciplinaDeAlunoPorId(int idDisciplina, String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"SELECT tb_disciplina,* FROM tb_disciplina_aluno INNER JOIN tb_disciplina ON tb_disciplina_aluno.id_disciplina = tb_disciplina.id_disciplina WHERE tb_disciplina.id_disciplina = @id_disciplina AND tb_disciplina_aluno.matricula_aluno = @id_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_disciplina", idDisciplina);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar disciplinas de um aluno pelo nome da disciplina
    public DataTable BuscarDisciplinaDeAlunoPorNome(String nomeDisciplina, String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"SELECT tb_disciplina,* FROM tb_disciplina_aluno INNER JOIN tb_disciplina ON tb_disciplina_aluno.id_disciplina = tb_disciplina.id_disciplina WHERE tb_disciplina.disciplina LIKE @nome_disciplina AND tb_disciplina_aluno.matricula_aluno = @id_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@nome_disciplina", nomeDisciplina);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar disciplinas de um aluno pelo id do aluno
    public DataTable BuscarDisciplinasAluno(String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"SELECT tb_disciplina,* FROM tb_disciplina_aluno INNER JOIN tb_disciplina ON tb_disciplina_aluno.id_disciplina = tb_disciplina.id_disciplina WHERE tb_disciplina_aluno.matricula_aluno = @id_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar cursos de um aluno pelo seu id
    public DataTable BuscarCursosAluno(String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"SELECT tb_curso,* FROM tb_curso_aluno INNER JOIN tb_curso ON tb_curso_aluno.id_curso = tb_curso.id_curso WHERE tb_curso_aluno.matricula_aluno = @id_aluno";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar professores de um aluno através do seu id
    public DataTable BuscarProfessoresDeAluno(String idAluno)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"
            SELECT tb_professor.nome_professor, tb_professor.formacao, tb_professor.titulacao, tb_professor.email_professor
            FROM tb_curso_aluno
            INNER JOIN tb_curso_professor ON tb_curso_aluno.id_curso = tb_curso_professor.id_curso
            INNER JOIN tb_professor ON tb_curso_professor.id_professor = tb_professor.id_professor
            WHERE tb_curso_aluno.matricula_aluno = @id_aluno";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar professores de um aluno através do id do aluno e nome do professor
    public DataTable BuscarProfessorDeAlunoPorNome(String idAluno, String nomeProfessor)
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"
            SELECT tb_professor.nome_professor, tb_professor.formacao, tb_professor.titulacao, tb_professor.email_professor
            FROM tb_curso_aluno
            INNER JOIN tb_curso_professor ON tb_curso_aluno.id_curso = tb_curso_professor.id_curso
            INNER JOIN tb_professor ON tb_curso_professor.id_professor = tb_professor.id_professor
            WHERE tb_curso_aluno.matricula_aluno = @id_aluno AND tb_professor.nome_professor LIKE @nome_professor";

            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);
            cmd.Parameters.AddWithValue("@nome_professor", "%" + nomeProfessor + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }

    // Buscar professor de um aluno pelo id do aluno e id do professor
    public DataTable BuscarProfessorDeAlunoPorId(String idAluno, String idProfessor)
    {
        using(MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = @"
            SELECT tb_professor.nome_professor, tb_professor.formacao, tb_professor.titulacao, tb_professor.email_professor
            FROM tb_curso_aluno
            INNER JOIN tb_curso_professor ON tb_curso_aluno.id_curso = tb_curso_professor.id_curso
            INNER JOIN tb_professor ON tb_curso_professor.id_professor = tb_professor.id_professor
            WHERE tb_curso_aluno.matricula_aluno = @id_aluno AND tb_professor.id_professor = @id_professor";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id_aluno", idAluno);
            cmd.Parameters.AddWithValue("@id_professor", idProfessor);

            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }
    }
}