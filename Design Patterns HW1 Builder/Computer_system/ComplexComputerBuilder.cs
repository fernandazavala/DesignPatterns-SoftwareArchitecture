using System;

namespace Computer_system
{
    class ComplexComputerBuilder : ComputerBuilder
    {
		//The component being construct
		private Components _component = new Components();

		//we creathe the components with the caracteristics in especific
		public override void BuildCPU()
        {
            CPU_component cpu = new CPU_component();
            cpu.name = "AMD Ryzen";
            cpu.model = "Ryzen 9 5950X";
            cpu.price = 12969;
            _component.Add(cpu);
        }
		public override void BuildSpeakers()
		{
			Output_component sp = new Output_component();
			sp.name = "Beats";
			sp.model = "Beats Pill +";
			sp.price = 4199;
			sp.connector_type = "Bluetooth";
			_component.Add(sp);
		}

		public override void BuildHeadphones()
		{
			Output_component hdph = new Output_component();
			hdph.name = "Logitech";
			hdph.model = "Logitech G933";
			hdph.price = 4500;
			hdph.connector_type = "Bluetooth";
			_component.Add(hdph);
		}

		public override void BuildPrinter()
		{
			Printer_component pt = new Printer_component();
			pt.name = "Epson";
			pt.model = "Epson Readyprint TM-T20II";
			pt.price = 6222;
			pt.connector_type = "Bluetooth";
			_component.Add(pt);
		}

		public override void BuildMonitor()
		{
			Input_component mon = new Input_component();
			mon.name = "Sceptre";
			mon.model = "Sceptre C305W-2560UN";
			mon.price = 5414;
			mon.connector_type = "Wi-fi";
			_component.Add(mon);
		}

		public override void BuildKeyboard()
		{
			Input_component kb = new Input_component();
			kb.name = "Logitech";
			kb.model = "Logitech G Pro 920-009388";
			kb.price = 3599;
			kb.connector_type = "USB";
			_component.Add(kb);
		}

		public override void BuildMouse()
		{
			Input_component ms = new Input_component();
			ms.name = "Logitech";
			ms.model = "Logitech G502";
			ms.price = 2631;
			ms.connector_type = "Bluetooth";
			_component.Add(ms);
		}

		public override void BuildWebcam()
		{
			Input_component wbc = new Input_component();
			wbc.name = "Logitech";
			wbc.model = "Logitech 960-001280";
			wbc.price = 2499;
			wbc.connector_type = "C";
			_component.Add(wbc);
		}

		public override void BuildScanner()
		{
			Input_component sc = new Input_component();
			sc.name = "Epson";
			sc.model = "Epson WorkForce ES-50";
			sc.price = 2099;
			sc.connector_type = "3999";
			_component.Add(sc);
		}

		public override Components GetResult()
		{
			return _component;
		}
	}
}
