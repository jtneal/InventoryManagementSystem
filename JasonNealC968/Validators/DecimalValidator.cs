namespace JasonNealC968.Validators
{
    public class DecimalValidator(Control[] controls) : IValidator
    {
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
