namespace JasonNealC968.Validators;

public class CompositeValidator : IValidator
{
    private readonly List<IValidator> validators;

    public CompositeValidator(List<IValidator> validators)
    {
        this.validators = validators;
    }

    public bool Validate()
    {
        var isFormValid = true;

        foreach (var validator in validators)
        {
            if (!validator.Validate())
            {
                isFormValid = false;
            }
        }

        return isFormValid;
    }
}
