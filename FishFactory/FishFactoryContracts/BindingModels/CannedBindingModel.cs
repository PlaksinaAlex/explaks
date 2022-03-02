﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryContracts.BindingModels
{
	public class CannedBindingModel
	{
		public int? Id { get; set; }
		public string CannedName { get; set; }
		public decimal Price { get; set; }
		public Dictionary<int, (string, int)> CannedComponents { get; set; }
	}
}