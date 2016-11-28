using SavingsAccumulator.DataContext;
using SavingsAccumulator.View_Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SavingsAccumulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainViewModel _mainViewModel; 
        public MainPage()
        {
            this.InitializeComponent();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            TargetControl.OnTargetSaved += TargetControl_OnTargetSaved;
            //TransactionControl.TransactionSaveFinished += TransactionControl_TransactionSavedFinished;
            TransactionControl.TransactionSaveFinished += TransactionControl_TransactionSaveFinished;

            

           // DataContextHelper.deleteAlltargets();

            //instanceded when page loads
            //if app goes to sleep it will see that the view model is not null and continue where it left off
            if (_mainViewModel == null) {
                _mainViewModel = new MainViewModel();

                _mainViewModel.OnDeleteFinished += _mainViewModel_OnDeleteFinished;
                //used main view model to get data from
                DataContext = _mainViewModel;

            }

        }

        private void _mainViewModel_OnDeleteFinished(object sender, EventArgs e)
        {
            TargetListView.ItemsSource = _mainViewModel.TargetList;//refreshs the list from the database after delete as finshed
        }

        private void TransactionControl_TransactionSaveFinished(object sender, EventArgs e)
        {
            TargetListView.ItemsSource = _mainViewModel.TargetList;//once program is saved the item source is set again and updated
        }

        // private void TransactionControl_TransactionSavedFinished(object sender, System.EventArgs e) {
        //     TargetListView.ItemsSource = _mainViewModel.TargetList;//once program is saved the item source is set again and updated
        // }
        private void TargetControl_OnTargetSaved(object sender, Model.Target e)
        {
            //throw new NotImplementedException();

            //adds new target to the list
            _mainViewModel.addNewTarget(e);
            TargetListView.ItemsSource = _mainViewModel.TargetList;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            //open the add target control
            TargetControl.Visibility = Visibility.Visible;
        }
    }
}
