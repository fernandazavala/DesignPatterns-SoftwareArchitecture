using System;

namespace Computer_system
{
	class SimpleComputerBuilder : ComputerBuilder
	{
		//The component being construct
		private Components _component = new Components();

		//we creathe the components with the caracteristics in especific
		public override void BuildCPU()
		{
			CPU_component cpu = new CPU_component();
			cpu.name = "Intel";
			cpu.model = "Intel i3";
			cpu.price = 2459;
			_component.Add(cpu);
		}
		public override void BuildSpeakers()
		{
			Output_component sp = new Output_component();
			sp.name = "Logitech";
			sp.model = "Logitech Z207";
			sp.price = 881;
			sp.connector_type = "Aux";
			_component.Add(sp);
		}

		public override void BuildHeadphones()
		{
			Output_component hdph = new Output_component();
			hdph.name = "Sony";
			hdph.model = "Sony WH-CH510";
			hdph.price = 998;
			hdph.connector_type = "Aux";
			_component.Add(hdph);
		}

		public override void BuildPrinter()
		{
			Printer_component pt = new Printer_component();
			pt.name = "HP";
			pt.model = "HP DeskJet Ink Advantage 2374";
			pt.price = 1249;
			pt.connector_type = "USB";
			_component.Add(pt);
		}

		public override void BuildMonitor()
		{
			Input_component mon = new Input_component();
			mon.name = "Asus";
			mon.model = "HVP228HE";
			mon.price = 3149;
			mon.connector_type = "HDMI";
			_component.Add(mon);
		}

		public override void BuildKeyboard()
		{
			Input_component kb = new Input_component();
			kb.name = "Logitech";
			kb.model = "Logitech K120";
			kb.price = 201;
			kb.connector_type = "USB";
			_component.Add(kb);
		}

		public override void BuildMouse()
		{
			Input_component ms = new Input_component();
			ms.name = "Logitech";
			ms.model = "Logitech M170";
			ms.price = 158;
			ms.connector_type = "USB";
			_component.Add(ms);
		}

		public override void BuildWebcam()
		{
			Input_component wbc = new Input_component();
			wbc.name = "Game Factor";
			wbc.model = "Game Factor WG400";
			wbc.price = 529;
			wbc.connector_type = "USB";
			_component.Add(wbc);
		}

		public override void BuildScanner()
		{
			Input_component sc = new Input_component();
			sc.name = "Canon";
			sc.model = "Canon SCACNN490";
			sc.price = 2099;
			sc.connector_type = "USB";
			_component.Add(sc);
		}

		public override Components GetResult()
		{
			return _component;
		}
	}
}