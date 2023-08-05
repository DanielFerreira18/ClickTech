using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_de_Aptidão_Profissional
{
    public class Informação_E_Formularios
    {
        private void Info_()
        {
            /* Informação Geral do Programa
             * 
             * Linhas de Código = 16.058;
             * 
             * Este programa é destinado a gestão de uma loja, é usado pelos
             * clientes da loja.
             * 
             * Este programa tem 3 forms e os restantes são 32 usercontrols.
             * 
             * Cada usercontrol é controlado a partir de um form, sendo esses forms,
             * o form Flayout ou o form de Login, dependendo de quem esta
             * a aceder a aplicação, se for um cliente inscrito ou quem esta a inscrever-se.
             * 
             * Os usercontrols são usados para não recriar a mesma layout do form Flayout
             * em varios forms, assim so se tem um form com a layout e os usercontrols são
             * carregados para a form flayout como um objeto aparecendo a interface grafica
             * que se apresenta no usercontrol escolhido.
             * 
             * Forms:
             * 
             * 1 - Form Loading - form de inicialização do programa, é um form com uma splashscreen
             * 2 - Form Login - form de login da conta do cliente
             * 3 - Form FLayout - form da layout, form principal do programa, onde a maioria das ações iram ocorrer
             * 
             * UserControls estão identificador por numeros para ser mais facil o seu uso, esta informação esta no metodo abaixo (Info_Usercontrols)
             */
        }

        private void Info_UserControls()
        {
            /* UserControls
             * 
             * Variavel Formulario de cada UserControl, usada para identificar cada UserControl
             * para ajudar.
             * 
             * UserControls Principais:
             * 
             * formulario Home = formulario 1
             * formulario Conta = formulario 2
             * formulario Mensagens = formulario 3
             * formulario Definições = formulario 4
             * formulario Computadores = formulario 5
             * formulario Equipamentos = formulario 6
             * formulario Componentes = formulario 7
             * formulario Configurador = formulario 8
             * formulario Carrinho = formulario 9
             * 
             * 
             * UserControls Secundarios:
             * 
             * Dependente do formulario 5
             *  - formulario PC_Portateis = formulario 10
             *  - formulario PC_Desktops = formulario 11
             *  
             * Dependente do formulario 6
             *  - formulario Equip_Ratos = formulario 12
             *  - formulario Equip_Teclados = formulario 13
             *  - formulario Equip_Tapetes = formulario 14
             *  - formulario Equip_Monitores = formulario 15
             *  - formulario Equip_HeadSets/Fones = formulario 16
             *  - formulario Equip_Cadeiras = formulario 17
             *  - formulario Equip_Colunas = formulario 18
             *  - formulario Equip_Pen/Cartoes = formulario 19
             *  - formulario Equip_Camaras = formulario 20
             *  - formulario Equip_Refrigerações = formulario 21
             *  
             *  Dependente do formulario 7
             *  - formulario Comp_MotherBoard= formulario 22
             *  - formulario Comp_Processadores = formulario 23
             *  - formulario Comp_PlacaGrafica = formulario 24
             *  - formulario Comp_DiscoRigido = formulario 25
             *  - formulario Comp_MemoriaRam = formulario 26
             *  - formulario Comp_PlacaRede = formulario 27
             *  - formulario Comp_LeitorCD = formulario 28
             *  - formulario Comp_Fonte = formulario 29
             *  - formulario Comp_Cooler = formulario 30
             *  - formulario Comp_Caixa = formulario 31
             *  
             *  Dependente do formulario 8
             *  - formulario Configurador2 = formulario 32
             * 
             */
        }
    }
}
