using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class PetType : EntityType
    {
        public PetType()
        {
            InstanceAccessors("Dog", "Cat");


            String("Name").Mandatory().Unique();

        }
    }
}
