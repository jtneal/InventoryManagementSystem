using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class RadioCheckedValidator : IValidator
    {
        private readonly RadioButton[] controls;

        public RadioCheckedValidator(RadioButton[] fields)
        {
            this.controls = fields;
        }

        public bool Validate()
        {
            return controls.Any(x => x.Checked);
        }
    }
}
