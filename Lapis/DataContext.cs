using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lapis
{
	class DataContext
	{
		public ObservableCollection<Charactor> Party { get; set; } = new ObservableCollection<Charactor>();

		public DataContext()
		{
			for(uint i = 0; i < 32; i++)
			{
				Party.Add(new Charactor(0x10 + i * 200));
			}
		}

		public uint Money
		{
			get { return SaveData.Instance().ReadNumber(0x56E0, 4); }
			set { Util.WriteNumber(0x56E0, 4, value, 9999999, 0); }
		}
	}
}
