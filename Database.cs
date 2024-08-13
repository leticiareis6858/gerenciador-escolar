using MySql.Data.MySqlClient;
using System;
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
        }
    }

    public DataTable GetDisciplinas()
    {
        using (MySqlConnection conn = GetConnection())
        {
            conn.Open();
            string query = "SELECT * FROM tb_disciplina";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
