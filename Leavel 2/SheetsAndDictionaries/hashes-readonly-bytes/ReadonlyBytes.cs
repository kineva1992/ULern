using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace hashes
{
	// TODO: Создайте класс ReadonlyBytes
	public class ReadonlyBytes : IEnumerable<byte>
	{
		List<byte> data = new List<byte>();
		StringBuilder strData = new StringBuilder();
		int hash = 0;

		public int Length { get { return data.Count; } }

		public ReadonlyBytes(params byte[] query)
		{
			if (query == null) throw new ArgumentNullException();
			foreach (var el in query)
				data.Add(el);
		}

		public override bool Equals(object obj)
		{
			if (!(obj is ReadonlyBytes) || obj.GetType() != typeof(ReadonlyBytes)) return false;
			var arr = obj as ReadonlyBytes;
			return arr.GetHashCode() == GetHashCode();
		}

		public override int GetHashCode()
		{
			int primeNum = 3123423;
			int previosX = 216613678;

			if (data.Count > 0 && hash == 0)
			{
				for (int i = 0; i < data.Count - 1; i++)
					previosX = unchecked((previosX * primeNum + data[i]) % (int)Math.Pow(2, 32));
				hash = unchecked((previosX * primeNum + data[data.Count - 1]) % (int)Math.Pow(2, 32));
			}
			return hash;
		}

		public override string ToString()
		{
			strData.Append('[');
			foreach (var el in data)
			{
				strData.Append(el);
				strData.Append(", ");
			}
			if (data.Count > 0)
				strData.Remove(strData.Length - 2, 2);
			strData.Append(']');
			return strData.ToString();
		}

		public IEnumerator<byte> GetEnumerator()
		{
			var index = 0;
			var current = data[index];
			while (true)
			{
				yield return current;
				if (index + 1 >= data.Count) break;
				index++;
				current = data[index];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public byte this[int index]
		{
			get
			{
				if (index < 0 || index >= data.Count) throw new IndexOutOfRangeException();
				return data[index];
			}
		}
	}
}