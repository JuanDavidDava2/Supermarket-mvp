﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
	internal class PayModePresenter
	{
		private IPayModeView view;
		private IPayModeRepository repository;
		private BindingSource payModeBindingSource;
		private IEnumerable<PayModeModel> payModeList;

		public PayModePresenter(IPayModeView view, IPayModeRepository repository)
		{
			this.payModeBindingSource = new BindingSource();

			this.view = view;
			this.repository = repository;

			this.view.SearchEvent += SearchPayMode;
			this.view.AddNewEvent += AddNewPayMode;
			this.view.EditEvent += LoadSelectPayModeToEdit;
			this.view.DeleteEvent += DeleteSelectedPayMode;
			this.view.SaveEvent += SavePayMode;
			this.view.CancelEvent += CancelAction;

			this.view.SetPayModeListBildingSource(payModeBindingSource);

			LoadAllPayModeList();

			this.view.Show();
		}

		private void LoadAllPayModeList()
		{
			payModeList = repository.GetAll();
			payModeBindingSource.DataSource = payModeList;
		}

		private void CancelAction(object? sender, EventArgs e)
		{
			CleanViewFields();
		}

		private void SavePayMode(object? sender, EventArgs e)
		{
			//Se crea un objeto de la clase PayModeModel y se asignan los datos de la caja de texto de la vista 
			var payMode = new PayModeModel();
			payMode.Id = Convert.ToInt32(view.PayModeId);
			payMode.Name = view.PayModeName;
			payMode.Observation = view.PayModeObservation;

			try 
			{
				new Common.ModelDataValidation().Validate(payMode);
				if (view.IsEdit)
				{
					repository.Edit(payMode);
					view.Message = "PayMode edited successfuly";
				}
				else
				{
					repository.Add(payMode);
					view.Message = "PayMode Added successfuly";
				}
				view.IsSuccessful = true;
				LoadAllPayModeList();
				CleanViewFields();
			}
			catch (Exception ex) 
			{
				//Si ocurre una excepcion se configura IsSuccessfull en false y la propiedad message de la vista
				//se asigna el mensaje de la excepcion.
				view.IsSuccessful = false;
				view.Message = ex.Message;
			}
		}

		private void CleanViewFields() 
		{
			view.PayModeId = "0";
			view.PayModeName = "";
			view.PayModeObservation = "";
		}
		private void DeleteSelectedPayMode(object? sender, EventArgs e)
		{
			try
			{
				var payMode = (PayModeModel)payModeBindingSource.Current;
				repository.Delete(payMode.Id);
				view.IsSuccessful = true;
				view.Message = "Pay Mode deleted succesfuly";
				LoadAllPayModeList();
			}
			catch (Exception ex)
			{
				view.IsSuccessful = false;
				view.Message = "A error ocurred, could not delete paymode";
			}
		}

		private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
		{
			//Se obtiene el objeto del datagridview que se encuentra seleccionado
			var payMode = (PayModeModel)payModeBindingSource.Current;

			//Se cambia el contenido de las cajas de texto por el objeto recuperado del datagridview
			view.PayModeId = payMode.Id.ToString();
			view.PayModeName = payMode.Name;
			view.PayModeObservation = payMode.Observation;

			//Se establece el modo como edicion
			view.IsEdit = true;
		}

		private void AddNewPayMode(object? sender, EventArgs e)
		{
			view.IsEdit = false;
		}

		private void SearchPayMode(object? sender, EventArgs e)
		{
			bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
			if (emptyValue == false)
			{
				payModeList = repository.GetByValue(this.view.SearchValue);
			}
			else 
			{
				payModeList = repository.GetAll();
			}
			payModeBindingSource.DataSource = payModeList;
		}
	}
}
