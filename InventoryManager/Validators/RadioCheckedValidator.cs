namespace JasonNealC968.Validators
{
    public class RadioCheckedValidator(RadioButton[] controls) : IValidator
    {
        public bool Validate()
        {
            return controls.Any(x => x.Checked);
        }
    }
}
