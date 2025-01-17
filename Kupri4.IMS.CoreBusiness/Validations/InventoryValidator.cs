﻿using FluentValidation;

namespace Kupri4.IMS.CoreBusiness.Validations;

public class InventoryValidator : AbstractValidator<Inventory>
{
    public InventoryValidator()
    {
        RuleFor(x => x.Name)
            .NotNull().WithMessage($"\"{nameof(Inventory.Name)}\": Field is required")
            .MinimumLength(3).WithMessage($"\"{nameof(Inventory.Name)}\": Minimal length is 3");

        RuleFor(x => x.Quantity)
           .ExclusiveBetween(0, 1000).WithMessage($"\"{nameof(Inventory.Quantity)}\": Must be between 1 and 999");

        RuleFor(x => x.Price)
           .GreaterThan(0.01m).WithMessage($"\"{nameof(Inventory.Price)}\": Must be positive");
    }
}
