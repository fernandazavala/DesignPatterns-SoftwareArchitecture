using System;

namespace Computer_system
{
	abstract class ComputerBuilder 
	{
		//Output components

		public abstract void BuildCPU();

		public abstract void BuildSpeakers();

		public abstract void BuildHeadphones();

		public abstract void BuildPrinter();

		public abstract void BuildMonitor();

		//Input components
		public abstract void BuildKeyboard();

		public abstract void  BuildMouse();

		public abstract void BuildWebcam();

		public abstract void BuildScanner();


		public abstract Components GetResult();
	}
}
