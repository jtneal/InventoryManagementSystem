using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasonNealC968.Validators
{
    public class RadioCheckedValidator : IValidator
    {
        private readonly RadioButton[] fields;

        public RadioCheckedValidator(RadioButton[] fields)
        {
            this.fields = fields;
        }

        public bool Validate()
        {
            return fields.Any(x => x.Checked);
        }
    }
}
