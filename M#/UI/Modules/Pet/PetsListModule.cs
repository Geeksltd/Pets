using MSharp;
using System;
using System.Collections.Generic;
using System.Text;
using UI.Pages.Admin.Settings.Pets;

namespace UI.Modules.Pet
{
    class PetsListModule : ListModule<Domain.Pet>
    {
        public PetsListModule()
        {
            HeaderText("My pets");

            Search(GeneralSearch.AllFields);
            Search(x => x.Name);
            
            SearchButton("Search").OnClick(x => x.Reload());

            Column(x => x.Name);
            Column(x => x.Type);
            ButtonColumn("Edit").OnClick(x => x.Go<EnterPage>().SendItemId().SendReturnUrl());
            ButtonColumn("Delete").ConfirmQuestion("Are you sure?").OnClick(x => x.DeleteItem());


            Button("Add a new pet").OnClick(x => x.Go<EnterPage>().SendReturnUrl());
        }
    }
}
