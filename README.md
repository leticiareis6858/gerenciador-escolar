# 🏫| Gerenciador Escolar
Este projeto consiste em uma aplicação para gestão escolar, onde é possível realizar a gestão de alunos, cursos, disciplinas e professores, além de permitir o cadastro de usuários para acesso à aplicação. É uma versão mais completa do projeto [Alunos](https://github.com/leticiareis6858/alunos).

# ⚙| Tecnologias usadas:
- C#
- Windows Forms
- MySQL
- Visual Studio

# 📝| Funcionalidades:
Através dessa aplicação é possível:
- Cadastrar um usuário para poder acessar a aplicação
- Recuperar a senha desse usuário
- Fazer login utilizando o usuário criado
- Gerenciar alunos, cursos, disciplinas, professores e a direção.

# 🔧| Instalação:
1. Clone o repositório ou faça download do arquivo `.zip` do mesmo
2. Instale e configure um banco de dados [MySQL](https://www.mysql.com)
3. Crie um *Schema* no MySQL com o nome `Escola`
4. Configure no `App.config` o *Uid* e a *Pwd* de acordo com seu *usuário* e *senha* do MySQL

# 👩‍💻| Como usar:
1. Execute a aplicação através do `FormLogin`
2. Cadastre um usuário para utilizar a aplicação

# 💻| Formulários:
- **FormLogin:** É o primeiro formulário a ser exibido ao iniciar a aplicação. Permite
que o usuário faça login na aplicação. Caso o usuário não seja cadastrado ele
pode ir para o formulário de cadastro clicando no link *“Novo usuário? Clique
aqui”*. E caso o usuário tenha esquecido sua senha, ele pode ir para o formulário
de recuperação de senha clicando no link *“Esqueceu a senha? Clique aqui”*.

- **FormTelaCadastroUsuário:** É o formulário que é exibido quando o usuário clica
no link *“Novo usuário? Clique aqui”* na tela de login. Permite que um novo usuário
seja cadastrado no banco de dados. Para cadastrar um usuário é necessário
informar nome, email e senha e clicar no botão *“cadastrar”*. Através desse
formulário é possível voltar ao formulário de login ao clicar no botão *“voltar”*.

- **FormRecuperarSenha:** Permite que um usuário cadastrado altere sua senha,
para isso ele precisa informar o nome e email cadastrados e a nova senha.
Através desse formulário também é possível voltar para o formulário de login.

- **FormTelaInicial:** É o formulário que é exibido assim que um usuário faz login.
Através desse formulário é possível ir aos formulários de cadastro de usuário,
atualização de usuário, exclusão de usuário, consulta de usuário e também voltar
ao formulário de login ao clicar no botão *“sair”*. Uma peculiaridade desse formulário
é que ele exibe uma mensagem de boas-vindas ao usuário, essa mensagem é
personalizada porque contém o nome do usuário logado. Para que a exibição do
nome de usuário fosse possível eu precisei usar a função
*“BuscarNomeUsuarioPorEmail”* na tela de login, para que o nome em exibição
fosse o nome cadastrado para o email informado ao fazer login. Também precisei
colocar uma label chamada *“txt_nome”* ou as vezes *“txt_usuario”* em alguns
formulários, para que o nome do usuário se mante-se salvo na aplicação conforme
ele navegasse por ela (o nome do usuário só é exibido na tela inicial, nos demais
formulários ele está com a propriedade *“visible”* configurada como *“false”*).

- **FormCadastrarAluno:** É acessado através do botão *“Cadastrar um aluno”*
localizado na tela inicial. Permite o cadastro de alunos por parte dos usuários
autenticados. Utilizei *“DateTimePicker”* para permitir a escolha da data de
nascimento dos alunos e usei uma *“comboBox”* para permitir a seleção do status
de matrícula do aluno a ser cadastrado, populei essa combo box pela própria
interface visual da IDE.
É importante ressaltar que alunos não podem fazer login na aplicação.

- **FormAtualizarAluno:** É acessível através do botão *“Atualizar aluno”* localizado na
tela inicial. Permite que o usuário atualize um aluno já cadastrado no banco de
dados. Também permite que o usuário pesquise um aluno pela sua matrícula ou
nome (parte ou inteiro). O formulário tem um *Data Grid View* que mostra todos os
alunos cadastrados no banco de dados, afim de auxiliar o usuário a consultar qual
usuário ele quer atualizar.

- **FormConsultarAlunos:** É acessado através do botão *“Pesquisar alunos”*
localizado na tela incial. Permite o usuário pesquisar todos os alunos cadastrados
ou um aluno especifico pelo seu número de matrícula, ou pesquisar alunos que
contenham em seu cadastro informações iguais as informadas no campo de
pesquisa.
A combo box *“Cidade”* exibe os valores de cidade informados no cadastro de
alunos já cadastrados

- **FormExcluirAluno:** É acessado pelo botão *“Excluir aluno”* localizado na tela
inicial. Permite a exclusão de um aluno pelo seu número de matrícula ou nome.
Nesse formulário há uma data grid view que mostra todos os alunos
cadastrados no banco de dados, e ao informar um número de matrícula ou
nome válido e clicar no botão *“Buscar”*, o usuário pode ver na data grid view as
informações do aluno buscado para ter certeza se é esse o aluno que ele
deseja excluir, se for basta clicar no botão *“Excluir”*.

# 📋| To-Do:
- [ ] Revisar esse projeto e verificar o que falta fazer
- [ ] Ajustar o Readme

# ⚖| Licença:
Este projeto está licenciado sob a [MIT License](LICENSE).
