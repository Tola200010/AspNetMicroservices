using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty().WithMessage("Order id is required.");
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Username is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("UserName must not exceed 50 characters.");
            RuleFor(x => x.EmailAddress)
                .NotNull()
                .WithMessage("{Email is required.");
            RuleFor(x => x.TotalPrice)
                .NotEmpty().WithMessage("Total Price is required.")
                .GreaterThan(0).WithMessage("Total Price should be greater than zero.");
        }
    }
}
