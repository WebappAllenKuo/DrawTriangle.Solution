namespace ConsoleApp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ROWS = 5;

            LeftAlignedTriangle(ROWS);
            Console.WriteLine();

			RightAlignedTriangle(ROWS);
			Console.WriteLine();

			CenterAlignedTriangle(ROWS);
			Console.WriteLine();

			Console.ReadKey();

		}

        /// <summary>
        /// 靠左三角形
        /// </summary>
        /// <param name="rows"></param>
        static void LeftAlignedTriangle(int rows)
        {
            for (int i = 1; i <= rows; i++)
            {
                string line = new string('*', i);
                Console.WriteLine(line);
			}
		}

		/// <summary>
		/// 靠右三角形
		/// </summary>
		/// <param name="rows"></param>
		static void RightAlignedTriangle(int rows)
		{
			for (int i = 1; i <= rows; i++)
			{
				string line = new string('*', i).PadLeft(rows);
				Console.WriteLine(line);
			}
		}

		/// <summary>
		/// 等腰三角形
		/// </summary>
		/// <param name="rows"></param>
		static void CenterAlignedTriangle(int rows)
		{
			for (int i = 1; i <= rows; i++)
			{
				string line =new string(' ', rows - i) +  
						new string('*', 2 * i - 1);
				Console.WriteLine(line);
			}
		}
	}
}
