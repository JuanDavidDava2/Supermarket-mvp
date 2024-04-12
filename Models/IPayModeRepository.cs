﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket_mvp.Models
{
	internal interface IPayModeRepository
	{
		void Add(PayModeModel payModeModel);
		void Edit(PayModeModel payModeModel);
		IEnumerable<PayModeModel> GetAll();
		IEnumerable<PayModeModel> GetByValue(string value);

	}
}
