using bootcampAvanadeDotNET.Models;

Pessoa p1 = new Pessoa(nome: "Ariel", sobrenome: "Pellegrino");
Pessoa p2 = new Pessoa(nome: "Corlouro", sobrenome: "Pellegrino");



Curso cursoDeingles = new Curso();

cursoDeingles.Nome = "Inglês";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();




/*p1.Nome = "Ariel";
Pessoa p1 = new Pessoa();
p1.Sobrenome = "Pellegrino";
p1.Idade = 30;
p1.Apresentar();*/