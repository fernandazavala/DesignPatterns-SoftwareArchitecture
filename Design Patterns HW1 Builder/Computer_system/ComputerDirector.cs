using System;

namespace Computer_system
{
	/// <summary>
	/// The menu director class.
	/// </summary>
	class ComputerDirector
	{
		/// <summary>
		/// Construct the menu using the specified builder.
		/// </summary>
		/// <param name="builder">The builder to use to construct the menu.</param>
		public void Construct(ComputerBuilder builder)
		{
			//No pongo todos, solo pongo los basicos
			builder.BuildCPU();
			builder.BuildMonitor();
			builder.BuildKeyboard();
		}
	}
}