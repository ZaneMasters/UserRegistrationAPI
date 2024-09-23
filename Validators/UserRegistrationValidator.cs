using FluentValidation;

public class UserRegistrationValidator : AbstractValidator<UserRegistrationDto>
{
    public UserRegistrationValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre es obligatorio.")
            .MaximumLength(100).WithMessage("El nombre no puede exceder 100 caracteres.");

        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("El teléfono es obligatorio.")
            .Matches(@"^\+?\d{10,15}$").WithMessage("El teléfono debe ser válido.");

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("La dirección es obligatoria.");

        RuleFor(x => x.CountryId)
            .GreaterThan(0).WithMessage("El país es obligatorio.");

        RuleFor(x => x.DepartmentId)
            .GreaterThan(0).WithMessage("El departamento es obligatorio.");

        RuleFor(x => x.MunicipalityId)
            .GreaterThan(0).WithMessage("El municipio es obligatorio.");
    }
}
