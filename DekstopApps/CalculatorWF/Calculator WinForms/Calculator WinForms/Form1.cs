namespace Calculator_WinForms
{
    public enum Operation 
    {
        Addition,
        Substraction,
        Divison,
        Multiplication,
        None
    }
    public partial class Form1 : Form
    {
        public string  _firstValue;

        public Operation _currentOperation = Operation.None;

        public string _secondValue;

        private bool _isTheResultOnTheScreen;
        public Form1()
        {
            InitializeComponent();
            tbScreen.Text = "O";
        }
     
        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;//rzutowanie obiektu na button. dzieki czemu to co klikniemy zostanie wyswietlone

            if(tbScreen.Text == "O" && clickedValue != ".")           
                tbScreen.Text = string.Empty;

            if (_isTheResultOnTheScreen) 
            {
                _isTheResultOnTheScreen = false;
                tbScreen.Text = string.Empty;
                if (clickedValue == ".") 
                {
                    clickedValue = "0.";
                }
            }

            tbScreen.Text += clickedValue;
            SetResultBtnState(true);

            if (_currentOperation != Operation.None)           
                _secondValue += clickedValue;
            else
                SetOperationBtnState(true);
                

        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            _firstValue = tbScreen.Text;

            var operation = (sender as Button).Text;

            _currentOperation = operation switch
            {
                "+" => Operation.Addition,
                "-" => Operation.Substraction,
                "/" => Operation.Divison,
                "*" => Operation.Multiplication,
                _  => Operation.None

            };

            tbScreen.Text += $" {operation} ";

            if (_isTheResultOnTheScreen)        
                _isTheResultOnTheScreen = false;
                
            SetOperationBtnState(false);
            SetResultBtnState(false);

        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {
            if (_currentOperation == Operation.None)
                return;

            
            var _firstNumber = double.Parse(_firstValue);
            var _secondNumber = double.Parse(_secondValue);

            var result = Calculate(_firstNumber,_secondNumber);

            tbScreen.Text = result.ToString();
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
            _isTheResultOnTheScreen = true;
            SetOperationBtnState(true);
            SetResultBtnState(true);
        }
        private double Calculate(double _firstNumber, double _secondNumber) 
        {
            switch (_currentOperation)
            {
                case Operation.Addition:
                    return  _firstNumber + _secondNumber;                   
                case Operation.Substraction:
                    return _firstNumber - _secondNumber;                   
                case Operation.Divison:
                    if (_secondNumber == 0)
                    {
                        MessageBox.Show(" Nie mo¿na dzieliæ przez 0! ");
                        return  0;
                    }
                    return _firstNumber / _secondNumber;                   
                case Operation.Multiplication:
                    return _firstNumber * _secondNumber;                    
                case Operation.None:
                    return _firstNumber;                  
            }
            return 0;
        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {
            tbScreen.Text = "0";
            _firstValue = string.Empty;
            _secondValue = string.Empty;
            _currentOperation = Operation.None;
        }

        private void SetOperationBtnState(bool value) 
        {
            BtnPlus.Enabled = value; 
            BtnMinus.Enabled = value;
            BtnMul.Enabled = value;
            BtnDiv.Enabled = value;

        }

        private void SetResultBtnState(bool value)
        {
            BtnEqual.Enabled = value;
           
        }
    }
}