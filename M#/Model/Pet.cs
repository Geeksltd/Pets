using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Pet : EntityType
    {
        public Pet()
        {
            String("Name").Mandatory().Unique().Max(300);
            DateTime("Date of birth").Mandatory();
            Associate<PetType>("Type").Mandatory();
        }
    }
}
