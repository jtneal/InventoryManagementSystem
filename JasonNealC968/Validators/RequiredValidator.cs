namespace JasonNealC968.Validators
{
    public class RequiredValidator(Control[] controls) : IValidator
    {
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
                    field.BackColor = Color.White;
            }

            return isValid;
        }
    }
}
