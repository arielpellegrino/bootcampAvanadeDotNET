using bootcampAvanadeDotNET.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Ariel";
p1.Sobrenome = "Pellegrino";

Pessoa p2 = new Pessoa();
p2.Nome = "Corlourlou";
p2.Sobrenome = "Pellegrino";


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