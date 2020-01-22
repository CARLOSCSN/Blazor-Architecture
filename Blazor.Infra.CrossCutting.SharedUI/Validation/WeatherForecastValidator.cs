using Common.ViewModel;
using FluentValidation;

namespace Common.Validation
{
    public class WeatherForecastValidator : AbstractValidator<WeatherForecastViewModel>
    {
        public WeatherForecastValidator()
        {
            //RuleFor(p => p.Summary).NotEmpty().WithMessage("You must enter a name");
            //RuleFor(p => p.Summary).MaximumLength(50).WithMessage("Name cannot be longer than 50 characters");
            RuleFor(p => p.Summary).Matches("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$").WithMessage("Please enter valid phone no.");
        }
    }
}
