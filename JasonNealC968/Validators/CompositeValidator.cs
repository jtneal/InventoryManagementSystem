using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class CompositeValidator : IValidator
    {
        private readonly IValidator[] validators;

        public CompositeValidator(IValidator[] validators)
        {
            this.validators = validators;
        }

        public bool Validate()
        {
            var isValid = true;

            foreach (var validator in validators)
            {
                if (!validator.Validate())
                {
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
