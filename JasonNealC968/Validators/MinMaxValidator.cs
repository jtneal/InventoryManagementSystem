namespace JasonNealC968.Validators
{
    public class MinMaxValidator(NumericUpDown control, NumericUpDown min, NumericUpDown max) : IValidator
    {
        public bool Validate()
        {
            bool isValid = true;

            if (control.Value < min.Value || control.Value > max.Value)
            {
                control.BackColor = Color.LightCoral;
                isValid = false;
            }

            if (min.Value > max.Value)
            {
                min.BackColor = Color.LightCoral;
                isValid = false;
            }

            return isValid;
        }
    }
}
