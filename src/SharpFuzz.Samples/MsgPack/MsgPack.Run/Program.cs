﻿using System.IO;

namespace MsgPack.Run
{
	public class Program
	{
		public static void Main(string[] args)
		{
			using (var file = File.OpenRead(args[0]))
			{
				Unpacking.UnpackObject(file);
			}
		}
	}
}
