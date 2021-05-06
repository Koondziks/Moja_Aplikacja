using MojaAplikacja.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MojaAplikacja.ViewModels
{
    public class MainWindowViewModel : Notifier
    {
        // Parameters for Cube
        private double _ca;

        public double CA
        {
            get { return _ca; }
            set
            {
                _ca = Math.Round(value, 2);
                OnPropertyChanged();
                CubeCalculate();
            }
        }


        private double _cb; 
        public double CB
        {
            get { return _cb; }
            set
            {
                _cb = Math.Round(value, 2);
                OnPropertyChanged();
                CubeCalculate();
            }
        }

        private double _cv;

        public double CV
        {
            get { return _cv; }
            set
            {
                _cv = Math.Round(value, 2);
                OnPropertyChanged();
            }
        }

        private double _ch;

        public double CH
        {
            get { return _ch; }
            set
            {
                _ch = Math.Round(value, 2);
                OnPropertyChanged();
                CubeCalculate();
            }
        }

        public void CubeCalculate()
        {
            if (CA <= 0 || CB <= 0 || CH <= 0)
                return;
            var cubevolume = new CubeVolume(CA,CB,CH);
            CV = cubevolume.CV;
        }
        
        //TUTAJ MAMY PARAMETRY WIDOKU, które nam się wyświetlaja w TextBox'ach dla Cylindra
        private double _r;

        public double R
        {
            get { return _r; }
            set
            {
                _r = Math.Round(value, 2);
                OnPropertyChanged();
                Calculate();
            }
        }

        private double _h;

        public double H
        {
            get { return _h; }
            set
            {
                _h = Math.Round(value, 2);
                OnPropertyChanged();
                Calculate();
            }
        }

        private double _v;

        public double V
        {
            get { return _v; }
            set
            {
                _v = Math.Round(value, 2);
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {

        }

        public void Calculate()
        {
            if (R <= 0 || H <= 0)
                return;
            var volume = new Volume(R, H);
            V = volume.V;
        }

        //public bool IsCylinderFigure
        //{
        //    get
        //    {
        //        if (figuresOption?.PropertyValue?.ToString() == "Cylinder")
        //            return true;
        //        else
        //            return false;
        //    }
        //}

        //public bool IsCubeFigure
        //{
        //    get
        //    {
        //        if (figuresOption?.PropertyValue?.ToString() == "Cube")
        //            return true;
        //        else
        //            return false;
        //    }
        //}

        //private void SetEvents()
        //{
        //    if (figuresOption != null)
        //        figuresOption.ValueChanged += (s, e) =>
        //        {
        //            OnPropertyChanged(nameof(IsCylinderFigure));
        //            OnPropertyChanged(nameof(IsCubeFigure));
        //        };
        //}

        public ObservableCollection<string> Figures { get; } = new ObservableCollection<string> { "Cylinder", "Cube" };

        private string selectedFigure="Cube";

        public string SelectedFigure
        {
            get { return selectedFigure; }
            set { selectedFigure = value;
                OnPropertyChanged(nameof(IsCubeFigure));
                OnPropertyChanged(nameof(IsCylinderFigure)); 
                OnPropertyChanged();
            }
        }

        public bool IsCubeFigure => SelectedFigure == "Cube";
        public bool IsCylinderFigure => SelectedFigure == "Cylinder";


    }
}
