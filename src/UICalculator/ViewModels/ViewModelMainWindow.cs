using DynamicData;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using static UICalculator.UIRelayCommand.UIRelayCommands;

namespace UICalculator.ViewModels
{
    public class ViewModelMainWindow
    {
        public ICommand DragMoveApp { get; }

        public ViewModelMainWindow()
        {
            DragMoveApp = new IRelayCommand(() =>
            { Application.Current.MainWindow?.DragMove(); }, () => true);
        }

        [Reactive]
        public int FontSizeProp { get; set; } = 18;

        [Reactive]
        public int FontSizeButtonsProp { get; set; } = 14;
    }
}
