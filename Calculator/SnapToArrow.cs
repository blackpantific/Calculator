using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public class SnapToArrow : INotifyPropertyChanged
    {
        public bool Picked { get; set; }

        public string SquareButton
        {
            get => squareButton;
            set
            {
                squareButton = value;
                OnPropertyChanged("SquareButton");
            }
        }
        public string XInDegreeButton
        {
            get => xInDegreeButton; set
            {
                xInDegreeButton = value;
                OnPropertyChanged("XInDegreeButton");
            }
        }
        public string SinusButton
        {
            get => sinusButton; set
            {
                sinusButton = value;
                OnPropertyChanged("SinusButton");
            }
        }
        public string CosinusButton
        {
            get => cosinusButton; set
            {
                cosinusButton = value;
                OnPropertyChanged("CosinusButton");
            }
        }
        public string TangensButton
        {
            get => tangensButton; set
            {
                tangensButton = value;
                OnPropertyChanged("TangensButton");
            }
        }
        public string SquareRootButton
        {
            get => squareRootButton; set
            {
                squareRootButton = value;
                OnPropertyChanged("SquareRootButton");
            }
        }
        public string TenXButton
        {
            get => tenXButton; set
            {
                tenXButton = value;
                OnPropertyChanged("TenXButton");
            }
        }
        public string LogarithmButton
        {
            get => logarithmButton; set
            {
                logarithmButton = value;
                OnPropertyChanged("LogarithmButton");
            }
        }
        public string ExponentButton
        {
            get => exponentButton; set
            {
                exponentButton = value;
                OnPropertyChanged("ExponentButton");
            }
        }
        public string ModButton
        {
            get => modButton; set
            {
                modButton = value;
                OnPropertyChanged("ModButton");
            }
        }

        //свойства для текста кнопок

        private string squareButton;
        private string xInDegreeButton;
        private string sinusButton;
        private string cosinusButton;
        private string tangensButton;

        private string squareRootButton;
        private string tenXButton;
        private string logarithmButton;
        private string exponentButton;
        private string modButton;

       

        public SnapToArrow()
        {
            TextDeclaration(false);
        }

        public void TextDeclaration(bool picked)
        {
            if (!picked)
            {
                this.SquareButton = "X^2";
                this.XInDegreeButton = "X^y";
                this.SinusButton = "sin";
                this.CosinusButton = "cos";
                this.TangensButton = "tan";
                this.SquareRootButton = "√";
                this.TenXButton = "10^x";
                this.LogarithmButton = "log";
                this.ExponentButton = "Exp";
                this.ModButton = "Mod";
            }
            else
            {
                this.SquareButton = "X^3";
                this.XInDegreeButton = "X^1/y";
                this.SinusButton = "sin^-1";
                this.CosinusButton = "cos^-1";
                this.TangensButton = "tan^-1";
                this.SquareRootButton = "1/x";
                this.TenXButton = "e^x";
                this.LogarithmButton = "ln";
                this.ExponentButton = "dms";
                this.ModButton = "deg";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        //МЕТОД, МЕНЯЮЩИЙ ТЕКСТ КНОПОК. ПРИНИМАЕТ В КАЧЕСТВЕ АГРУМЕНТА BOOL PICKED. САМА ПЕРЕМЕННАЯ МНЯЕТ ЗНАЧЕНИЕ ПРИ КЛИКЕ ПО КНОПКЕ СТРЕЛКА
        //ТАМ ЖЕ В ОБРАБОТЧИКЕ СОБЫТИЯ КЛИК ВЫЗЫВАЕТСЯ МЕТОД ПО ИЗМЕНЕНИЮ ТЕКСТА, В ЗАВИСИМОСТИ ОТ ЗНАЧЕНИЯ БУЛ ОН МЕНЯЕТСЯ.
    }
}
