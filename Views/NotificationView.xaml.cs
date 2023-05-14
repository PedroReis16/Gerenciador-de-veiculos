using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gerenciador_de_veículos.Views
{
    /// <summary>
    /// Interaction logic for NotificationView.xaml
    /// </summary>
    public partial class NotificationView : UserControl
    {
        List<string> mensagem;
        public NotificationView(List<string> mensagem)
        {
            InitializeComponent();
            this.mensagem = mensagem;

            LoadView();
        }
        public void LoadView()
        {
            if(mensagem.Count == 0)
            {
                Primeiro.Text = "";
                Segundo.Text = "";
                Terceiro.Text = "";
                Quarto.Text = "";
                Quinto.Text = "";
                return;
            }
            else if(mensagem.Count >= 1)
            {
                if(mensagem.Count == 1)
                {
                    Primeiro.Text = mensagem[0];
                    Segundo.Text = "";
                    Terceiro.Text = "";
                    Quarto.Text = "";
                    Quinto.Text = "";
                    return;
                }
                else
                {
                    if(mensagem.Count == 2)
                    {
                        Primeiro.Text = mensagem[mensagem.Count - 2];
                        Segundo.Text = mensagem[mensagem.Count - 1];
                        Terceiro.Text = "";
                        Quarto.Text = "";
                        Quinto.Text = "";
                        return;
                    }
                    else
                    {
                        if(mensagem.Count == 3)
                        {
                            Primeiro.Text = mensagem[mensagem.Count - 3];
                            Segundo.Text = mensagem[mensagem.Count - 2];
                            Terceiro.Text = mensagem[mensagem.Count - 1];
                            Quarto.Text = "";
                            Quinto.Text = "";
                            return;
                        }
                        else
                        {
                            if(mensagem.Count == 4)
                            {
                                Primeiro.Text = mensagem[mensagem.Count - 4];
                                Segundo.Text = mensagem[mensagem.Count - 3];
                                Terceiro.Text = mensagem[mensagem.Count - 2];
                                Quarto.Text = mensagem[mensagem.Count - 1];
                                Quinto.Text = "";
                                return;
                            }
                        }
                    }
                }
            }
            else
            {
                Primeiro.Text = mensagem[mensagem.Count - 5];
                Segundo.Text = mensagem[mensagem.Count - 4];
                Terceiro.Text = mensagem[mensagem.Count - 3];
                Quarto.Text = mensagem[mensagem.Count - 2];
                Quinto.Text = mensagem[mensagem.Count - 1];
            }
            
        }
    }
}
