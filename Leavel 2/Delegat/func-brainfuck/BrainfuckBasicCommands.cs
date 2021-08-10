using System;
using System.Collections.Generic;
using System.Linq;

namespace func.brainfuck
{
	public class BrainfuckBasicCommands
	{
		public static void RegisterTo(IVirtualMachine vm, Func<int> read, Action<char> write)
		{
			vm.RegisterCommand('.', b => write((char)b.Memory[b.MemoryPointer]));
			unchecked
			{
				vm.RegisterCommand('+', b => b.Memory[b.MemoryPointer]++);
				vm.RegisterCommand('-', b => b.Memory[b.MemoryPointer]--);
			}
			foreach (char i in Enumerable.Range('0', 10).Concat(Enumerable.Range('A', 26).Concat(Enumerable.Range('a', 26))))
				vm.RegisterCommand(i, b => b.Memory[b.MemoryPointer] = (byte)i);

			vm.RegisterCommand(',', b => b.Memory[b.MemoryPointer] = (byte)read());
			vm.RegisterCommand('>', b => { b.MemoryPointer = ++b.MemoryPointer % b.Memory.Length; });
			vm.RegisterCommand('<',
				b => { b.MemoryPointer = --b.MemoryPointer < 0 ? b.Memory.Length - 1 : b.MemoryPointer; });
		}
	}
}