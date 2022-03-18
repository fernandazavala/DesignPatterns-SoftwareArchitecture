// Builder pattern: A creation al design pattern that lets you produce different types and representations of an object using the same building process. Builder allows constructing complex objects step by step
// This is the ideal pattern for this type of problem because even though we have different types of computers, they all work the same way, but we have to omit certain components - peripherals in case the customer doesn't want them, which is not ideal for another type of pattern
using System;

namespace Computer_system
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create the director 
            ComputerDirector director = new ComputerDirector();

            // create builder1 using the Simple Computer Builder
            ComputerBuilder builder1 = new SimpleComputerBuilder();
            director.Construct(builder1);

            // create builder2 using the Complex Computer Builder
            ComputerBuilder builder2 = new ComplexComputerBuilder();
            director.Construct(builder2);

            Console.Write("Custom Computer Configuration System \n");
            Console.Write("Select the complexity of the computer you are looking for \n");
            Console.Write("1. Simple computer: for reading PDF files and using a web browser \n");
            Console.Write("2. Complex computer: for software design and development purposes (programming) \n");
            int option = Convert.ToInt32(Console.ReadLine()); //in order to cast the string to int and be able to implement the switch
            if (option == 1) //if the computer is the Simple one
            {
                bool flag = true; //in order to make it false when we want to end the program (when it returns the total)
                while (flag)
                {
                    //displays the menu
                    Console.Write("Select the components you want to include in your computer \n");
                    Console.Write("consider that it will always have by default the CPU, monitor and keyboard corresponding to the category you selected \n");
                    Console.Write("1 CPU: Intel i3 \n");
                    Console.Write("2 Speakers: Logitech Z207 \n");
                    Console.Write("3 Headphones: Sony WH-CH510 \n");
                    Console.Write("4 Printer: HP DeskJet Ink Advantage 2374 \n");
                    Console.Write("5 Monitor: Asus HVP228HE \n");
                    Console.Write("6 Keyboard: Logitech K120 \n");
                    Console.Write("7 Mouse: Logitech M170 \n");
                    Console.Write("8 Webcam: Game Factor WG400 \n");
                    Console.Write("9 Scanner: Canon SCACNN490 \n");
                    Console.Write("0: Dejar de seleccionar componentes y obtener total a pagar \n");
                    int x = Convert.ToInt32(Console.ReadLine()); //here we recieve the variable that tell us which component does the client want 
                    switch(x)
                    {
                        case 1:
                            builder1.BuildCPU();
                            break;
                        case 2:
                            builder1.BuildSpeakers();
                            break;
                        case 3:
                            builder1.BuildHeadphones();
                            break;
                        case 4:
                            builder1.BuildPrinter();
                            break;
                        case 5:
                            builder1.BuildMonitor();
                            break;
                        case 6:
                            builder1.BuildKeyboard();
                            break;
                        case 7:
                            builder1.BuildMouse();
                            break;
                        case 8:
                            builder1.BuildWebcam();
                            break;
                        case 9:
                            builder1.BuildScanner();
                            break;
                        case 0:
                            Console.Write("El total a pagar es el siguiente: ");
                            Console.Write(builder1.GetResult().Sum());
                            flag = false; //we convert the flag into false so it doesn't displays the menu again
                            break;
                        default:
                            Console.Write("La opción no es válida, seleccione otra opción \n"); //if the client doesn´t select a component or wants to exit the system
                            break;
                    }

                }

            }

            else if (option == 2) //if the computer is the complex one
            {

                bool flag = true; //in order to make it false when we want to end the program (when it returns the total)
                while (flag)
                {
                    Console.Write("Select the components you want to include in your computer \n");
                    Console.Write("1 CPU: Ryzen 9 5950X \n");
                    Console.Write("2 Speakers: Beats Pill + \n");
                    Console.Write("3 Headphones: Logitech G933 \n");
                    Console.Write("4 Printer: Epson Readyprint TM-T20II \n");
                    Console.Write("5 Monitor: Sceptre C305W-2560UN \n");
                    Console.Write("6 Keyboard: Logitech G Pro 920-009388 \n");
                    Console.Write("7 Mouse: Logitech G502 \n");
                    Console.Write("8 Webcam: Logitech 960-001280 \n");
                    Console.Write("9 Scanner: Epson WorkForce ES-50 \n");
                    Console.Write("0: Dejar de seleccionar componentes y obtener total a pagar \n");

                    int x = Convert.ToInt32(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            builder2.BuildCPU();
                            break;
                        case 2:
                            builder2.BuildSpeakers();
                            break;
                        case 3:
                            builder2.BuildHeadphones();
                            break;
                        case 4:
                            builder2.BuildPrinter();
                            break;
                        case 5:
                            builder2.BuildMonitor();
                            break;
                        case 6:
                            builder2.BuildKeyboard();
                            break;
                        case 7:
                            builder2.BuildMouse();
                            break;
                        case 8:
                            builder2.BuildWebcam();
                            break;
                        case 9:
                            builder2.BuildScanner();
                            break;
                        case 0:
                            Console.Write("El total a pagar es el siguiente: ");
                            Console.Write(builder2.GetResult().Sum());
                            flag = false;
                            break;
                        default:
                            Console.Write("La opción no es válida, seleccione otra opción \n");
                            break;
                    }
                }
                
            }
            _ = Console.ReadLine(); //so the console doesn't close and the client can see the total
        }
        
        
    }

}