using MVP_V1.Models;
using MVP_V1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_V1.Presenters
{
    public class PetPresenter
    {
        // Fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        // Constructor
        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            // Subscribe to event handler methods to view events
            this.view.SearchEvent += SeachPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;

            //Set pets binded  source
            this.view.SetPetListBindingSource(petsBindingSource);
            LoadAllPetList();
            this.view.Show();
        }
        
        
        // Methods
        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void SeachPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(this.view.SearchValue);
            if (emptyValue == false)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType= pet.Type;
            view.PetColour = pet.Colour;
            view.IsEdit = true;
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.Message = "Pet deleted successfully.";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error occur, could not delete pet." + ex.Message;
            }
        }

        private void SavePet(object sender, EventArgs e)
        {
            // capture the inputs to Model
            // validate the fields
            // check if its creating / editing item
            // reload the list
            // clear the fields

            var pet = new PetModel();
            pet.Id = Convert.ToInt32(view.PetId);
            pet.Name = view.PetName;
            pet.Type = view.PetType;
            pet.Colour = view.PetColour;

            try
            {
                new Common.ModelDataValidation().Validate(pet);
                if (view.IsEdit) // Edit Model
                {
                    repository.Edit(pet);
                    view.Message = "Pet updated successfully.";
                }
                else
                {
                    Console.WriteLine("adding pet");
                    repository.Add(pet);
                    view.Message = "Pet added successfully.";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }

        }

        private void CleanviewFields()
        {
            view.PetId = "0";
            view.PetName = "";
            view.PetType = "";
            view.PetColour = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }
    }
}
