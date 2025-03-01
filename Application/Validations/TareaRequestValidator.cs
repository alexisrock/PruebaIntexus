using Domain.Dto.Request;
using FluentValidation;

namespace Application.Validations
{
    public class TareaRequestValidator : AbstractValidator<TareaRequest>
    {

        public TareaRequestValidator()
        {
            RuleFor(x => x.NameTarea)
               .NotEmpty().WithMessage("El userName es obligatorio")
               .MinimumLength(2).WithMessage("El nombre debe tener al menos 2 caracteres");

            RuleFor(x => x.DescriptionTarea)
                .NotEmpty().WithMessage("El password es obligatorio")
                .MinimumLength(2).WithMessage("El password debe tener al menos 2 caracteres");

        }


    }


    public class TareaUpdateRequestValidator : AbstractValidator<TareaupdateRequest>
    {

        public TareaUpdateRequestValidator()
        {

            RuleFor(x => x.IdTarea)
                .Must(n => n >= 0).WithMessage("El id de la tarea debe ser mayor que cero.");

           
        }


    }
}
