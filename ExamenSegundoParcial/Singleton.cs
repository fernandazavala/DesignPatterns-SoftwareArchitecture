using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Configuration;

namespace ExamenSegundoParcial
{
	class Singleton
	{
		// this field holds the singleton instance
		private static Singleton _instance = null;
		public dynamic DB = 0;

		// this field holds the lock handle for thread locking
		private static object _handle = new object();

		/// <summary>
		/// Initializes a new instance of the <see cref="SingletonPattern.Singleton"/> class.
		/// </summary>
		/// <remarks>Note that the constructor is protected which makes it inaccessible to clients.</remarks>
		protected Singleton()
		{
		}

		/// <summary>
		/// Gets the singleton instance.
		/// </summary>
		/// <value>The instance of the singleton.</value>
		public static Singleton Instance
		{
			get
			{
				// thread-safe lazy initialization
				// remove this lock statement if your code is not multi-threaded
				lock (_handle)
				{
					if (_instance == null)
					{
						_instance = new Singleton();
					}
				}

				return _instance;
			}
		}

		public static Singleton GetInstance()
		{
			if (_instance == null)
			{
				_instance = new Singleton();
			}
			return _instance;
		}

		public void createDB()
        {
			using (StreamReader reader = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + ConfigurationSettings.AppSettings.Get("DataBase_Grades")))
			{ 
				string rawData = reader.ReadToEnd();
				DB = JsonConvert.DeserializeObject(rawData);
			}
		}

	}
}
