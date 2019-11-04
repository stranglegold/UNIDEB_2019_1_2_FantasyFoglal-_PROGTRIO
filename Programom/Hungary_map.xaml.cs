using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Programom
{
    /// <summary>
    /// Interaction logic for Hungary_map.xaml
    /// </summary>
    /// 
    public class NAryDictionary<TKey, TValue> :
       Dictionary<TKey, TValue>
    {
    }

    public class NAryDictionary<TKey1, TKey2, TValue> :
        Dictionary<TKey1, NAryDictionary<TKey2, TValue>>
    {
    }

    public class NAryDictionary<TKey1, TKey2, TKey3, TValue> :
        Dictionary<TKey1, NAryDictionary<TKey2, TKey3, TValue>>
    {
    }

    public class Játék
    {

    }



    public partial class Hungary_map : Window
    {
        static NAryDictionary<int, NAryDictionary<String, bool>> Kérdések = new NAryDictionary<int, NAryDictionary<string, bool>>()
        {1, { } };
        static Dictionary<int, Dictionary<String, bool>> Magyarkérdések = new Dictionary<int, Dictionary<string, bool>>
      { 1, {{"Magyarország fővárosa Budapest.", true} {"Magyarország fővárosa Debrecen.", true} }};

        protected int score { get; set; }
        

        public Hungary_map()
        {
            InitializeComponent();
        }

        private void ShowScore()
        {
            Pontok.Text = "Pontok: " + score.ToString() + " pont";
        }

        private void Nyugatészak_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Nyugatközép_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Nyugatalsó_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Baranya_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Északfelső_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Shithole_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Jobbbészak_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Keletnyírség_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Keletközép_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void MiddleMiddle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Middleleft_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Tolna_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void MiddleDél_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
