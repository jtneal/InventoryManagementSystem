namespace JasonNealC968.Validators
{
    public class CompositeValidator(IValidator[] validators) : IValidator
    {
        public bool Validate()
        {
            var isValid = true;

            foreach (var validator in validators)
                if (!validator.Validate())
                    isValid = false;

            return isValid;
        }
    }
}
