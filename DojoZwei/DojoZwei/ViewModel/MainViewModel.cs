using System;
using System.Security.AccessControl;
using GalaSoft.MvvmLight;
using System.Windows.Threading;
using GalaSoft.MvvmLight.CommandWpf;

namespace DojoZwei.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private string dTime;
        private string dDate;
        private DispatcherTimer dispTimer;
        private RelayCommand btnSenHinzu;
        private RelayCommand btnAktHinzu;
        private RelayCommand btnSenDelete;
        private RelayCommand btnAktDelete;

        public RelayCommand BtnAktHinzu
        {
            get { return btnAktHinzu; }
            set { btnAktHinzu = value; }
        }
        public RelayCommand BtnSenHinzu
        {
            get { return btnSenHinzu; }
            set { btnSenHinzu = value; }
        }
        public RelayCommand BtnAktDelete
        {
            get { return btnAktDelete; }
            set { btnAktDelete = value; }
        }
        public RelayCommand BtnSenDelete
        {
            get { return btnSenDelete; }
            set { btnSenDelete = value; }
        }




        public string DTime
        {
            get { return System.DateTime.Now.TimeOfDay.ToString().Remove(5); }
            set { dTime = value; RaisePropertyChanged(); }
        }

        public string DDate
        {
            get { return System.DateTime.Today.ToString().Remove(10); }
            set { dDate = value; RaisePropertyChanged(); }
        }

        public DispatcherTimer DispTimer
        {
            get { return dispTimer; }
            set { dispTimer = value; }
        }



        public MainViewModel()
        {
            dispTimer = new DispatcherTimer();
            dispTimer.Interval = new TimeSpan(0, 0, 10);
            dispTimer.Tick += dispatcherTimer_Tick;
            dispTimer.Start();
        }


        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            DDate = DDate;
            DTime = DTime;
        }
    }
}