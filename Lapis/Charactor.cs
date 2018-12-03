using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lapis
{
	class Charactor : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public Charactor(uint address)
		{
			mAddress = address;
		}

		public String Name
		{
			get { return SaveData.Instance().ReadText(mAddress, 21); }
			set
			{
				SaveData.Instance().WriteText(mAddress, 21, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
			}
		}

		public uint Job
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 28, 2); }
			set { SaveData.Instance().WriteNumber(mAddress + 28, 2, value); }
		}

		public uint Color
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 32, 1); }
			set { SaveData.Instance().WriteNumber(mAddress + 32, 1, value); }
		}

		public uint Hair
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 36, 1); }
			set { SaveData.Instance().WriteNumber(mAddress + 36, 1, value); }
		}

		public uint Voice
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 40, 1); }
			set { SaveData.Instance().WriteNumber(mAddress + 40, 1, value); }
		}

		public uint Attack
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 96, 4); }
			set { SaveData.Instance().WriteNumber(mAddress + 96, 4, value); }
		}

		public uint HP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 100, 4); }
			set { SaveData.Instance().WriteNumber(mAddress + 100, 4, value); }
		}


		private readonly uint mAddress;
	}
}
