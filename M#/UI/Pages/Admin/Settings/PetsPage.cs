using Admin;
using MSharp;
using System;
using System.Collections.Generic;
using System.Text;
using UI.Modules.Pet;

namespace UI.Pages.Admin.Settings
{
    class PetsPage : SubPage<SettingsPage>
    {
        public PetsPage()
        {
            Add<PetsListModule>();
        }
    }
}
