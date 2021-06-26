
namespace ControleDao.DAO
{
    public class Contato : DominioBase
    {
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Empresa { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }

        public string ValidarCampos()
        {
            string auxValidacao = "";
            if (Nome == "") auxValidacao += "Campo Nome Vazio\n";
            if (Empresa == "") auxValidacao += "Campo Empresa Vazio\n";
            if (Email == "") auxValidacao += "Campo Email Vazio\n";
            if (Cargo == "") auxValidacao += "Campo Cargo Vazio\n";
            if (Telefone == "") auxValidacao += "Campo Telefone Vazio\n";
            if (!ValidarEmail()) auxValidacao += "Email Invalido!\n";
            if (Telefone.Length < 9) auxValidacao += "Telefone Invalido!";
            if (auxValidacao == "")
            {
                return "Valido";
            }
            else return auxValidacao;
        }

        private bool ValidarEmail()
        {
            bool arroba = false, ponto = false;
            foreach (char letra in Email)
            {
                if (letra == '@') arroba = true;
                if (letra == '.') ponto = true;
            }
            return (arroba && ponto) ? true : false;
        }
    }
}