using System.Collections.Generic;

namespace func.brainfuck
{
	public class BrainfuckLoopCommands
	{
		public static void RegisterTo(IVirtualMachine vm)
		{
			Dictionary<int, int> indexes = new Dictionary<int, int>();
			FindBracketsIndexes(vm.Instructions, indexes);

			vm.RegisterCommand('[', b => {
				if (b.Memory[b.MemoryPointer] == 0)
					b.InstructionPointer = indexes[b.InstructionPointer];
			});


			vm.RegisterCommand(']', b => {
				if (b.Memory[b.MemoryPointer] != 0)
					b.InstructionPointer = indexes[b.InstructionPointer];

			});
		}

		private static void FindBracketsIndexes(string command, Dictionary<int,int> indexes)
		{
			var bracketIndexs = new Stack<int>();
            for (int i = 0; i < command.Length; i++)
            {
				if (command[i] == '[')
					bracketIndexs.Push(i);
				else if (command[i] == ']')
				{
					var t = bracketIndexs.Pop();
					indexes.Add(t, i);
					indexes.Add(i, t);
				}

            }
		}
	}
}