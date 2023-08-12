using System;
using BloggerAPI.Models;
using FluentValidation;

namespace BloggerAPI.Validations
{
    public class AuthRequestValidator : AbstractValidator<AuthRequest>
    {
        public AuthRequestValidator()
        {
            RuleFor(p => p.Email).NotEmpty().EmailAddress();
            RuleFor(p => p.Password).NotEmpty().MinimumLength(6);
        }
    }
}

