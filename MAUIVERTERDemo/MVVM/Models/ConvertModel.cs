using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIVERTERDemo.MVVM.Models
{
	[AddINotifyPropertyChangedInterface]
	public class ConvertModel
	{
		public string QuantityName { get; set; }
		public ObservableCollection<string> FromMeasures { get; set; }	
		public ObservableCollection<string> ToMeasures { get; set; }
		public string CurrentFromMeasure { get; set; }
		public string CurrentToMeasure { get; set; }
		public double FromValue { get; set; } = 1;
		public double ToValue { get; set; }
	}
}
