using Core.Entities.Utilities.EntityGenerator;
using Core.Entities.Utilities.EntityGenerator.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.Profiles
{
    public class UserGeneratorProfile : BaseGeneratorProfile<Users>
    {
        public UserGeneratorProfile()
        {
            RuleForParameter(w => w.IdUser).IsUnique().MinValue(567);
            RuleForParameter(w => w.BirthDate).DateStart(new DateTime(1990, 01, 01)).DateEnd(new DateTime(1996, 12, 31));
            RuleForParameter(w => w.Email).IsEmail().TextFormat(TextFormats.OnlyText).IsUnique();
            RuleForParameter(w => w.Phone).IsPhoneNumber().IsUnique();
            RuleForParameter(w => w.Username).MaxLeng(10).TextFormat(TextFormats.OnlyText).IsUnique();
            RuleForParameter(w => w.h).MaxValue('k').MinValue('d');
            
         
        }
    }
}
