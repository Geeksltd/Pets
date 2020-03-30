using MSharp;
using System;
using System.Collections.Generic;
using System.Text;
using UI.Modules.Pet;

namespace UI.Pages.Admin.Settings.Pets
{
    class EnterPage : SubPage<PetsPage>
    {
        public EnterPage()
        {
            Add<PetsFormModule>();
        }
    }
}
