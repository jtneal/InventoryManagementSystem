namespace JasonNealC968.Validators
{
    public class IntegerValidator(Control[] controls) : IValidator
    {
        public bool Validate()
        {
            bool isValid = true;

            foreach (var control in controls)
            {
                if (!int.TryParse(control.Text, out _))
                {
                    control.BackColor = Color.LightCoral;
                    isValid = false;
                }
            }

            return isValid;
        }
    }
}
