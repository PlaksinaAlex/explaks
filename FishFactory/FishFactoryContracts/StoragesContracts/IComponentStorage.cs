﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FishFactoryContracts.BindingModels;
using FishFactoryContracts.ViewModels;


namespace FishFactoryContracts.StoragesContracts
{
	public interface IComponentStorage
	{
		List<ComponentViewModel> GetFullList();
		List<ComponentViewModel> GetFilteredList(ComponentBindingModel model);
		ComponentViewModel GetElement(ComponentBindingModel model);
		void Insert(ComponentBindingModel model);
		void Update(ComponentBindingModel model);
		void Delete(ComponentBindingModel model);
	}
}