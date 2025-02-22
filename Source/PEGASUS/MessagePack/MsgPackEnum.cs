using System.Collections;
using System.Collections.Generic;

namespace Engine.Metafora_Dedomenon
{
	public class MsgPackEnum : IEnumerator
	{
		private readonly List<MsgPack> children;

		private int position = -1;

		object IEnumerator.Current => children[position];

		public MsgPackEnum(List<MsgPack> obj)
		{
			children = obj;
		}

		bool IEnumerator.MoveNext()
		{
			position++;
			return position < children.Count;
		}

		void IEnumerator.Reset()
		{
			position = -1;
		}
	}
}
