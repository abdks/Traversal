using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementDTOs>
    {
        public AnnouncementValidator()
        {
            RuleFor(x=>x.Title).NotEmpty().WithMessage("Boş Geçemeszin");
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Boş Geçemeszin");
        }
    }
}
