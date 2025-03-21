using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class RequiredValidator : IValidator
    {
        private readonly Control[] controls;

        public RequiredValidator(Control[] controls)
        {
            this.controls = controls;
        }

        public bool Validate()
        {
            bool isValid = true;

            foreach (var field in controls)
            {
                if (string.IsNullOrEmpty(field.Text))
                {
                    field.BackColor = Color.LightCoral;
                    isValid = false;
                }
                else
                {
                    field.BackColor = Color.White;
                }
            }

            return isValid;
        }
    }
}
