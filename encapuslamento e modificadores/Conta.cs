using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapuslamento_e_modificadores
{
    class Conta
    {
        public int numero;
        public double saldo;

        //public Cliente titular;

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }
        public double PegaSaldo()
        {
            return this.saldo;
        }
        public void ColocaNumero(int numero)
        {
            this.numero = numero;
        }

        // questao 1
        //public int Numero { get; private set; }
        //O número pode ser lido, mas não pode ser alterado por outras classes.

        // questao 2
        //Conta c = new Conta();
        //double valorADepositar = 200.0;
        //c.Saldo += valorADepositar; //A operação de depósito não está encapsulada, podendo gerar problemas futuros de manutenção. Os problemas estão relacionados ao fato de posteriormente não ter acesso para alterar/acessar os valores

        //questão 3 É esconder COMO a classe/método faz sua tarefa. Caso a regra mude, temos que alterar apenas um ponto do código.

        // questão 4 public double Saldo { get; set; } >> O atributo Saldo pode ser manipulado por outras classes. Isso vai contra a regra do encapsulamento. De nada adianta criar Properties e permitir que todos os atributos sejam modificados pelas outras classes.

        // questao 5
        //public class Conta
        //{
        //    public int Numero { get; set; }
        //    public double Saldo { get; private set; }
        //    public Cliente Titular { get; set; }
        //    public void Deposita(double valor)
        //        {
        //        this.Saldo += valor;
        //        }
        //    public void Saca(double valor)
        //    {
        //        this.Saldo -= valor;
        //    }
        //}

    }
}
