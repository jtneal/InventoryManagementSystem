using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class MinMaxValidator : IValidator
    {
        private readonly NumericUpDown field;
        private readonly NumericUpDown min;
        private readonly NumericUpDown max;

        public MinMaxValidator(NumericUpDown field, NumericUpDown min, NumericUpDown max)
        {
            this.field = field;
            this.min = min;
            this.max = max;
        }

        public bool Validate()
        {
            bool valid = true;

            if (field.Value < min.Value || field.Value > max.Value)
            {
                field.BackColor = Color.LightCoral;
                valid = false;
            }

            return valid;
        }
    }
}
