using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Model
{   
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public int QuantidadeHospede {get;set;}

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // *IMPLEMENTE AQUI*
            QuantidadeHospede = hospedes == null ? 0 : hospedes.Count();
            try
            {
            if (Suite.Capacidade >= QuantidadeHospede)
            {
                Hospedes = hospedes;
            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                // *IMPLEMENTE AQUI*                
               
                throw new Exception("Erro");
            }
            }
            catch(Exception erro)
            {
                Console.WriteLine($"Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes", erro.Message);
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {            
            return QuantidadeHospede;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // *IMPLEMENTE AQUI*
            decimal valor = 0;
            decimal desconto = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // *IMPLEMENTE AQUI*https://web.dio.me/lab/desafio-de-projeto/learning/abbfc217-49a4-432a-a39f-b3ead8f22029
            if (DiasReservados >= 10)
            {
                desconto = 0.1M;
            }

            valor = (DiasReservados * Suite.ValorDiaria) - ((DiasReservados * Suite.ValorDiaria) * desconto);

            return valor;
        } 
    }
}
