using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Desktop.ValidadoresComponentes
{
    public class ValidadorTextBox
    {
        public bool ValidarTextBoxesPreenchidos(Control parent)
        {
            var mensagensErro = new List<string>(); // Lista para coletar mensagens de erro
            bool temCamposPreenchidos = false; // Flag para verificar se pelo menos um campo está preenchido

            try
            {
                // Verifica todos os controles filhos do 'parent'
                foreach (Control control in parent.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        // Se o TextBox estiver vazio, adiciona a mensagem de erro
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            mensagensErro.Add($"O campo '{textBox.Name}' está vazio. Por favor, preencha-o.");
                        }
                        else
                        {
                            temCamposPreenchidos = true; // Marca que pelo menos um campo está preenchido
                        }
                    }
                }

                // Se houver mensagens de erro, exibe a MessageBox
                if (mensagensErro.Count > 0)
                {
                    MessageBox.Show(string.Join(Environment.NewLine, mensagensErro), "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Retorna verdadeiro se pelo menos um campo foi preenchido
                return temCamposPreenchidos;
            }
            catch (Exception ex) // Captura exceções para análise
            {
                // Lança a exceção novamente ou lida conforme necessário
                MessageBox.Show("Erro na validação: " + ex.Message);
                throw;
            }
        }
    }
}
