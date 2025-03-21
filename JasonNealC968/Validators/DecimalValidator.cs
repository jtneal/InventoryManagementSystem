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
            bool isValid = true;

            foreach (var control in controls)
            {
                if (!decimal.TryParse(control.Text, out _))
                {
                    control.BackColor = Color.LightCoral;
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
