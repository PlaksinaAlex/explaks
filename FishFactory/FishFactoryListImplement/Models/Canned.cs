﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryListImplement.Models
{
	public class Canned
	{
		public int Id { get; set; }
		public string CannedName { get; set; }
		public decimal Price { get; set; }
		public Dictionary<int, int> CannedComponents { get; set; }
	}
}