namespace JasonNealC968.Validators;

public class NumericValidator : IValidator
{
    private readonly Control field;

    public NumericValidator(Control field)
    {
        this.field = field;
    }

    public bool Validate()
    {
        bool valid = true;
        bool isNumeric = decimal.TryParse(field.Text, out _);

        if (!isNumeric)
        {
            field.BackColor = Color.LightCoral;
            valid = false;
        }

        return valid;
    }
}
