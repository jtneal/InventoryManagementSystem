using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class IntegerValidator : IValidator
    {
        private readonly Control[] controls;

        public IntegerValidator(Control[] controls)
        {
            this.controls = controls;
        }

        public bool Validate()
        {
            bool valid = true;

            foreach (var control in controls)
            {
                bool isNumeric = int.TryParse(control.Text, out _);

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
