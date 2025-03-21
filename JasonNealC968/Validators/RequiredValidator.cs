using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class RequiredValidator : IValidator
    {
        private readonly List<Control> requiredFields;

        public RequiredValidator(List<Control> requiredFields)
        {
            this.requiredFields = requiredFields;
        }

        public bool Validate()
        {
            bool valid = true;

            foreach (var field in requiredFields)
            {
                if (string.IsNullOrEmpty(field.Text))
                {
                    field.BackColor = Color.LightCoral;
                    valid = false;
                }
                else
                {
                    field.BackColor = Color.White;
                }
            }

            return valid;
        }
    }
}
