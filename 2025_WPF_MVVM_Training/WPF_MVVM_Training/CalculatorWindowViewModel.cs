using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFBasics;

namespace WPF_MVVM_Training
{
    public class CalculatorWindowViewModel : BaseViewModel
    {
        double lastValue;

        List<double> values = new List<double>();

        List<string> operatorsToExecute = new List<string>();

        string operatorToExecute;

        public CalculatorWindowViewModel()
        {
            this.NumberCommand = new DelegateCommand((numberStringValue) =>
            {
                int val = int.Parse((string)numberStringValue);

                this.CurrentValue = this.CurrentValue * 10 + val;
            });


            this.OperatorCommand = new DelegateCommand(ExecuteOperation);
        }


        private double _CurrentValue;
        public double CurrentValue
        {
            get => _CurrentValue;
            set
            {
                _CurrentValue = value;
                this.RaisePropertyChanged();
            }
        }


        /// <summary>
        /// schon nicht so ohne, dass sauber für mehrere Werte hintereinander hinzubekommen:        /// 
        /// da gibt es vieles zu berücksichtigen. 
        /// 
        /// richtig komplex wäre es, eine stringeingabe zu parsen
        /// 
        /// für die Ausgabe schöner ist es, aus den Eingaben einen Formelstring zu bauen
        /// und intern mit den Werten zu rechnen. aber da hat der ansatz, den ich hier
        /// kurz probierte, auch noch viele lücken und unschöne momente.
        /// 
        /// eigentlich müsste alles erst untersucht werden, um rechenregeln und ggf.
        /// klammern zu berücksichtigen.
        /// </summary>

        //private string _Formula;
        //public string Formula
        //{
        //    get { return _Formula; }
        //    set
        //    {
        //        _Formula = value;
        //        this.RaisePropertyChanged();
        //    }
        //}


        public DelegateCommand NumberCommand { get; set; }


        // ggf mit einem weiteren OperatorCommand für = für mehr Übersichtlichkeit
        public DelegateCommand OperatorCommand { get; set; }


        void ExecuteOperation(object operatorStringValue)
        {
            string op = (string)operatorStringValue;

            if (operatorStringValue.Equals("="))
            {
                switch (operatorToExecute)
                {
                    case "+":
                        CurrentValue += lastValue;
                        break;
                    case "-":
                        CurrentValue = lastValue - _CurrentValue;
                        break;
                    case "*":
                        CurrentValue *= lastValue;
                        break;
                    case "/":
                        CurrentValue = lastValue / _CurrentValue;
                        break;

                    default:
                        break;
                }
            }
            else
            {
                this.operatorToExecute = op;
                lastValue = _CurrentValue;
                CurrentValue = 0.0;
            }

            //this.operatorToExecute = op;

            //lastValue = _CurrentValue;

            //this.operatorsToExecute.Add(op);
            //this.values.Add(lastValue);

            //CurrentValue = 0.0;

            ////Formula = BuildFormula();

            //if (op.Equals("="))
            //{
            //    operatorsToExecute.Clear();
            //    values.Clear();
            //}


        }

        //private string BuildFormula()
        //{
        //    string formula = string.Empty;
        //    string result = string.Empty;

        //    double interimResult = 0.0;

        //    for (int i = 0; i < values.Count; i++)
        //    {

        //        if (i == 0)
        //        {
        //            interimResult = values[0];

        //            formula += $"{interimResult} ";
        //        }

        //        if (i < operatorsToExecute.Count && i + 1 < values.Count)
        //        {
        //            bool error;

        //            (interimResult, error) = Calculate(interimResult, values[i + 1], operatorsToExecute[i]);

        //            formula += $"{operatorsToExecute[i]} {values[i + 1]} ";

        //            if (error)
        //            {
        //                return formula += $"invalid operation";
        //            }

        //        }

        //        if (operatorsToExecute[i].Equals("="))
        //        {
        //            formula += $"= {interimResult}";
        //        }
        //    }



        //    return formula;
        //}

        //private (double, bool) Calculate(double interimResult, double nextValue, string nextOperator)
        //{
        //    string formula = string.Empty;
        //    bool arithmeticError = false;

        //    switch (nextOperator)
        //    {
        //        case "+":
        //            interimResult += nextValue;
        //            break;

        //        case "-":
        //            interimResult -= nextValue;
        //            break;

        //        case "*":
        //            interimResult *= nextValue;
        //            break;

        //        case "/":

        //            if (nextValue == 0.0)
        //            {
        //                arithmeticError = true;

        //                return (interimResult, arithmeticError);
        //            }

        //            interimResult /= nextValue;

        //            break;

        //        default:
        //            break;
        //    }


        //    return (interimResult, arithmeticError);
        //}

    }
}
