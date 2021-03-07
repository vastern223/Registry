using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
namespace Registry
{
    using Microsoft.Win32;   
    public partial class MainWindow : Window
    {
        int curent_color = 0;
        int curent_font_size = 0;

        public MainWindow()
        {
            InitializeComponent();
            Color_Change();
            Font_Size_Change();
        }

        public void Addition_to_the_register()
        {
            RegistryKey currentUserKey = Registry.CurrentUser;
            RegistryKey helloKey = currentUserKey.CreateSubKey("color_dz");
            helloKey.SetValue("color",curent_color, RegistryValueKind.DWord);
            helloKey.SetValue("fontSize",curent_font_size, RegistryValueKind.DWord);
            helloKey.Close();           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {        
            Registry.SetValue(
              @"HKEY_CURRENT_USER\color_dz",
              "color",0);
            Color_Change();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(
            @"HKEY_CURRENT_USER\color_dz",
            "color", 1);
            Color_Change();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(
            @"HKEY_CURRENT_USER\color_dz",
            "color", 2);
            Color_Change();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            int res = (int)Registry.GetValue(
                   @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Themes\Personalize",
                   "AppsUseLightTheme", null);

            if (res == 1) 
            { 
                curent_color = 1; 
                main_grid.Background = new SolidColorBrush(Colors.White);
                menuMain.Background = new SolidColorBrush(Colors.White);

                foreach (MenuItem item in menuMain.Items)
                {
                    foreach (MenuItem item2 in menuitem.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.White);
                        item2.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    item.Background = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.White);
                    item.BorderBrush = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                }

                menuMain1.Background = new SolidColorBrush(Colors.White);

                foreach (MenuItem item in menuMain1.Items)
                {
                    foreach (MenuItem item2 in menuitem1.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.White);
                        item2.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    item.Background = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.White);
                    item.BorderBrush = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                }
            }
            else if (res == 0) 
            {
                curent_color = 0;

                main_grid.Background = new SolidColorBrush(Colors.Black);
                menuMain.Background = new SolidColorBrush(Colors.Black);

                foreach (MenuItem item in menuMain.Items)
                {
                    foreach (MenuItem item2 in menuitem.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.Black);
                        item2.Foreground = new SolidColorBrush(Colors.White);
                    }
                    item.Background = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                    item.BorderBrush = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.White);
                }

                menuMain1.Background = new SolidColorBrush(Colors.Black);

                foreach (MenuItem item in menuMain1.Items)
                {
                    foreach (MenuItem item2 in menuitem1.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.Black);
                        item2.Foreground = new SolidColorBrush(Colors.White);
                    }
                    item.Background = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                    item.BorderBrush = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.White);
                }
            }
          
        }
        public void Color_Change()
        {
            int res = (int)Registry.GetValue(
               @"HKEY_CURRENT_USER\color_dz",
               "color", null);

            if(res == 0){ 
                curent_color = 0; 
                main_grid.Background = new SolidColorBrush(Colors.Black);
                
                menuMain.Background = new SolidColorBrush(Colors.Black);       
             
                foreach (MenuItem item in menuMain.Items)
                {                  
                    foreach (MenuItem item2 in menuitem.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.Black);
                        item2.Foreground = new SolidColorBrush(Colors.White);
                    }
                    item.Background = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                    item.BorderBrush = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.White);
                }

                menuMain1.Background = new SolidColorBrush(Colors.Black);

                foreach (MenuItem item in menuMain1.Items)
                {
                    foreach (MenuItem item2 in menuitem1.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.Black);
                        item2.Foreground = new SolidColorBrush(Colors.White);
                    }
                    item.Background = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                    item.BorderBrush = new SolidColorBrush(Colors.Black);
                    item.Foreground = new SolidColorBrush(Colors.White);
                }

            }
            else if (res == 1) 
            { curent_color = 1; 
                main_grid.Background = new SolidColorBrush(Colors.White);

                menuMain.Background = new SolidColorBrush(Colors.White);

                foreach (MenuItem item in menuMain.Items)
                {
                    foreach (MenuItem item2 in menuitem.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.White);
                        item2.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    item.Background = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.White);
                    item.BorderBrush = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                }

                menuMain1.Background = new SolidColorBrush(Colors.White);

                foreach (MenuItem item in menuMain1.Items)
                {
                    foreach (MenuItem item2 in menuitem1.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.White);
                        item2.Foreground = new SolidColorBrush(Colors.Black);
                    }
                    item.Background = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.White);
                    item.BorderBrush = new SolidColorBrush(Colors.White);
                    item.Foreground = new SolidColorBrush(Colors.Black);
                }

            }
            else if (res == 2) 
            { curent_color = 2; 
                main_grid.Background = new SolidColorBrush(Colors.Red);
               
                menuMain.Background = new SolidColorBrush(Colors.Red);

                foreach (MenuItem item in menuMain.Items)
                {
                    foreach (MenuItem item2 in menuitem.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.Red);
                        item2.Foreground = new SolidColorBrush(Colors.White);
                    }
                    item.Background = new SolidColorBrush(Colors.Red);
                    item.Foreground = new SolidColorBrush(Colors.Red);
                    item.BorderBrush = new SolidColorBrush(Colors.Red);
                    item.Foreground = new SolidColorBrush(Colors.White);
                }

                menuMain1.Background = new SolidColorBrush(Colors.Red);

                foreach (MenuItem item in menuMain1.Items)
                {
                    foreach (MenuItem item2 in menuitem1.Items)
                    {
                        item2.Background = new SolidColorBrush(Colors.Red);
                        item2.Foreground = new SolidColorBrush(Colors.White);
                    }
                    item.Background = new SolidColorBrush(Colors.Red);
                    item.Foreground = new SolidColorBrush(Colors.Red);
                    item.BorderBrush = new SolidColorBrush(Colors.Red);
                    item.Foreground = new SolidColorBrush(Colors.White);
                }
            }

           
           
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Addition_to_the_register();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(
            @"HKEY_CURRENT_USER\color_dz",
            "fontSize",5);
            Font_Size_Change();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(
            @"HKEY_CURRENT_USER\color_dz",
            "fontSize",10);
            Font_Size_Change();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(
            @"HKEY_CURRENT_USER\color_dz",
            "fontSize", 15);
            Font_Size_Change();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            Registry.SetValue(
             @"HKEY_CURRENT_USER\color_dz",
            "fontSize", 20);
            Font_Size_Change();

        }

        public void Font_Size_Change()
        {
            int res = (int)Registry.GetValue(
               @"HKEY_CURRENT_USER\color_dz",
               "fontSize", null);

            if (res == 5) { curent_font_size = 5; menuitem.FontSize = 5; menuitem1.FontSize = 5; }
            else if (res == 10) { curent_font_size = 10;  menuitem.FontSize = 10; menuitem1.FontSize = 10; }
            else if (res == 15) { curent_font_size = 15;  menuitem.FontSize = 15; menuitem1.FontSize = 15; }
            else if (res == 20) { curent_font_size = 20;  menuitem.FontSize = 20; menuitem1.FontSize = 20; }
    
                                                   
        }
    }
}
