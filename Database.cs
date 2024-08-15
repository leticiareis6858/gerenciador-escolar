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
}
