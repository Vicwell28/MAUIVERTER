using MAUIVERTERDemo.MVVM.Models;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnitsNet;

namespace MAUIVERTERDemo.MVVM.ViewModels
{
	public class ConvertViewModel
	{
		public ConvertModel model {  get; set; }
		public ICommand ReturnCommand { get; private set; }

		public ConvertViewModel(string quantityName)
		{
			this.model = new ConvertModel();
			this.model.QuantityName = quantityName;
			this.model.FromMeasures = LoadMeasures();
			this.model.ToMeasures = LoadMeasures();
			this.model.CurrentFromMeasure = this.model.FromMeasures.FirstOrDefault();
			this.model.CurrentToMeasure = this.model.ToMeasures.Skip(1).FirstOrDefault();
			this.ReturnCommand = new Command(this.Convert);
			this.Convert();
		}

		public void Convert()
		{
			double result = UnitConverter
				.ConvertByName(
				this.model.FromValue, 
				this.model.QuantityName,
				this.model.CurrentFromMeasure, 
				this.model.CurrentToMeasure);

			this.model.ToValue = result;
		}

		private ObservableCollection<string> LoadMeasures()
		{
			List<string> list = Quantity
						.Infos
						.FirstOrDefault(x => x.Name == this.model.QuantityName)
						.UnitInfos
						.Select(x => x.Name)
						.ToList();

			return new ObservableCollection<string>(list);
		}
	}
}
