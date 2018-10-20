using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Recursos.App_Code;

namespace XF.Recursos.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuView : ContentPage
	{
        public ListView ListView { get { return lstMenu; } }
        public MenuView()
        {
            InitializeComponent();

            ObservableCollection<OpcoesMenu> menuItems = 
                new ObservableCollection<OpcoesMenu>();
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Home",
                Icone = "Home.png",
                TargetType = typeof(HomeView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Editor",
                Icone = "",
                TargetType = typeof(Controles.EditorView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Data",
                Icone = "",
                TargetType = typeof(Controles.PickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "List Picker",
                Icone = "",
                TargetType = typeof(Controles.ListPickerView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Stepper",
                Icone = "",
                TargetType = typeof(Controles.StepperView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Controle de Progresso",
                Icone = "",
                TargetType = typeof(Controles.ProgressoView)
            });
            menuItems.Add(new OpcoesMenu
            {
                Descricao = "Uso do Command",
                Icone = "",
                TargetType = typeof(Exemplo.CommandView)
            });
            lstMenu.ItemsSource = menuItems;
        }
    }
}