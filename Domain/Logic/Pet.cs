using Olive.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public partial class Pet
    {
        public override async Task Validate()
        {
            await base.Validate();

            /// custom validation
            /// 
            if (Type == PetType.Dog)
                throw new ValidationException("Dogs are not supported now.");
        }
    }
}
