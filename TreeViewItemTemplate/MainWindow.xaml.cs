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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TreeViewItemTemplate {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            this.treeView.ItemsSource = new List<Person> {
                new Person{
                    Name = "田中　一郎",
                    Children =  new List<Person>{
                        new Person {
                            Name = "鈴木　次郎",
                            Children = new List<Person>{
                                new Person{
                                    Name = "木村　花子",
                                    Children = new List<Person>{
                                        new Person {Name = "木村　はな"},
                                        new Person {Name = "木村　たえ"},
                                    }
                                }
                            }
                        }
                    }
                },
                new Person{Name = "吉田　拓郎",
                    Children = new List<Person> {
                        new Person{Name = "吉田　太郎"}
                    }
                }
            };
        }
    }
}
