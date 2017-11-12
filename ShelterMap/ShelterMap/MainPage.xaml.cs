using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShelterMap
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();

            Title = "TOP"; //ページのタイトル


        }
    }

    /// <summary>
    /// マップ
    /// </summary>
    class MapPage : ContentPage
    {
        public MapPage()
        {
            Title = "マップ";


        }
    }
    
    /// <summary>
    /// チェックリスト
    /// </summary>
    class CheckListPage : ContentPage
    {
        public CheckListPage()
        {
            Title = "チェックリスト";


        }
    }

    /// <summary>
    /// アラート
    /// </summary>
    class BellPage : ContentPage
    {
        public BellPage()
        {
            Title = "アラート";


        }
    }
}
