using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class DecimalValidator : IValidator
    {
        private readonly Control[] controls;

        public DecimalValidator(Control[] controls)
        {
            this.controls = controls;
        }

        public bool Validate()
        {
            bool valid = true;

            foreach (var control in controls)
            {
                bool isNumeric = decimal.TryParse(control.Text, out _);

                if (!isNumeric)
                {
                    control.BackColor = Color.LightCoral;
                    valid = false;
                }
            }

            return valid;
        }
    }
}
