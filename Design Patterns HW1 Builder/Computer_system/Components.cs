using System;
using System.Collections.Generic;

namespace Computer_system
{
	class Components
	{
		private List<Component> _parts = new List<Component>();

		//used to add the necessary components
		public void Add(Component part)
		{
			_parts.Add(part);
		}

		//is used to calculate the total to pay once the customer has selected the components they want
		public float Sum()
		{
			float res = 0;
			for(int i=0; i < _parts.Count; i++)
            {
				res = res + _parts[i].price;
            }
			return res;
		}
	}

	//describes the features that are included in all components (regardless of whether they are input or output)
	abstract class Component
    {
		public string name = " "; //manufacturer name
		public string model = " "; //product model 
		public float price = 0; //product price
		
    }

	//describes the features that are included in all input components, so you know what type of connector they use
	class Input_component : Component
    {
		public string connector_type = " ";
		public int[] valid_port = { 1, 2, 3, 4 };
	}

	//describes the features that are included in all output components, so you know what type of connector they use
	class Output_component : Component
    {
		public string connector_type = " ";
		public int[] valid_port = { 1, 2, 3, 4 };
	}

	//the characteristics that are included in all the components related to printing are described, to know if the printer is an inkjet or laser
	class Printer_component : Output_component
    {
		public string cardcartridge_type = " ";
	}

	//is added because it is neither an input nor an output component and must always be included
	class CPU_component : Component
    {

    }
}
