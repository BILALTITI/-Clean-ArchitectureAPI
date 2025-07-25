using FluentValidation;
using School_Project.Core.Features.Students.Commands.Models;
using School_Project.Service.Abstracts;

namespace School_Project.Core.Features.Students.Commands.Validotors
{
    public class EditStudentValidator : AbstractValidator<EditStudentCommand>
    {



        #region Fileds
        private readonly IstudentSrvice _studentSrvice;
        #endregion
        #region Constractor

        public EditStudentValidator(IstudentSrvice studentSrvice)
        {
            _studentSrvice = studentSrvice;
            ApplyValidationRules();
            ApplyCustomValidationRules();
        }

        #endregion
        #region Actions
        public void ApplyValidationRules()
        {
            RuleFor(x => x.Name)
       .NotEmpty()
       .WithMessage(x => $"Name is required. (Value: '{x.Name}')")
       .NotNull()
       .WithMessage(x => $"Name must not be null.")
       .MaximumLength(20)
       .WithMessage(x => $"Name '{x.Name}' cannot exceed 20 characters.");

            RuleFor(x => x.Address)
                .NotEmpty()
                .WithMessage(x => $"Address is required. (Value: '{x.Address}')")
                .MaximumLength(50)
                .WithMessage(x => $"Address '{x.Address}' cannot exceed 50 characters.");

            RuleFor(x => x.Phone)
                .NotEmpty()
                .WithMessage(x => $"Phone is required. (Value: '{x.Phone}')")
                .MaximumLength(10)
                .WithMessage(x => $"Phone '{x.Phone}' cannot exceed 15 characters.");

            RuleFor(x => x.departmentId)
                .GreaterThan(0)
                .WithMessage(x => $"DepartmentId must be greater than 0. (Value: '{x.departmentId}')");
        }


        public void ApplyCustomValidationRules()
        {
            RuleFor(x => x.Name)
                .MustAsync(async (model, name, cancellation) =>
                {
                    return !await _studentSrvice.IsNameExsistExcludeSelf(name, model.Id);
                })
                .WithMessage("Name already exists.");
        }


        #endregion
    }
}
