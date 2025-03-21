using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class MinMaxValidator : IValidator
    {
        private readonly NumericUpDown control;
        private readonly NumericUpDown min;
        private readonly NumericUpDown max;

        public MinMaxValidator(NumericUpDown control, NumericUpDown min, NumericUpDown max)
        {
            this.control = control;
            this.min = min;
            this.max = max;
        }

        public bool Validate()
        {
            bool isValid = true;

            if (control.Value < min.Value || control.Value > max.Value)
            {
                control.BackColor = Color.LightCoral;
                isValid = false;
            }

            return isValid;
        }
    }
}
