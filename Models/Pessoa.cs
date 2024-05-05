using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcampAvanadeDotNET.Models {
	public class Pessoa {
		private string _nome;
		private int _idade;
		public string Nome {
			get => _nome.ToUpper();
			
			set{
				if (value == null){
					throw new ArgumentNullException("O nome não pode ser vazio");
				}
				_nome = value;
			}
		}
		public int Idade {
			get => _idade;
			set{
				if (value < 0){
					throw new ArgumentException("A idade não pode ser menor que zero");
				}
			}
		}

		public void Apresentar() {
			Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
		}
	}
}