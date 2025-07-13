namespace ConsoleApp02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DrawFilledDiamond(9);
			Console.WriteLine();
			
			DrawOutlineDiamond(9);
			Console.WriteLine();

			Console.ReadKey();
		}

		/// <summary>
		/// 繪製實心菱形
		/// </summary>
		/// <param name="rows"></param>
		static void DrawFilledDiamond(int rows) {
			// pre-condition: rows must be odd
			if (rows % 2 == 0)
			{
				throw new ArgumentException("Rows must be an odd number.");
			}

			int n = (rows - 1) / 2;
			int start = -1 * n;

			for (int i = start; i <= n; i++) {
				int spaceCount = i == 0 ? 0 : Math.Abs(i);
				int starCount = (n - Math.Abs(i) + 1) * 2 - 1;
				string line = new string(' ', spaceCount) +
					new string('*', starCount);
				Console.WriteLine(line);
			}
		}

		/// <summary>
		/// 繪製空心菱形
		/// </summary>
		/// <param name="rows"></param>
		static void DrawOutlineDiamond(int rows)
		{
			// pre-condition: rows must be odd
			if (rows % 2 == 0)
			{
				throw new ArgumentException("Rows must be an odd number.");
			}

			int n = (rows - 1) / 2;
			int start = -1 * n;

			for (int i = start; i <= n; i++)
			{
				int spaceCount = i == 0 ? 0 : Math.Abs(i);
				int starCount = (n - Math.Abs(i) + 1) * 2 - 1;
				string stars = new string('*', starCount);

				// 保留前後兩個星號
				if (starCount > 1)
				{
					stars = stars[0] +
						new string(' ', starCount - 2) +
						stars[stars.Length-1];
				}

				string line = new string(' ', spaceCount) + stars;

				Console.WriteLine(line);
			}
		}


	}
}
