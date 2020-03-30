using MSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.Modules.Pet
{
    class PetsFormModule : FormModule<Domain.Pet>
    {
        public PetsFormModule()
        {
            HeaderText("Pet details");

            Field(x => x.Name);
            Field(x => x.Type).Control(ControlType.AutoComplete);
            Field(x => x.DateOfBirth);

            Button("Save").OnClick(x =>
            {
                x.SaveInDatabase();
                x.ReturnToPreviousPage();
            });

            Button("Cancel").OnClick(x => x.ReturnToPreviousPage());
        }
    }
}
