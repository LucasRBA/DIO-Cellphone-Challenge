namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(long cellphoneNumber, string model, long imei, int memory, int storageCapacity) : base(cellphoneNumber, model, imei, memory,storageCapacity)
        {
             
        }

        public Iphone() {}

        public override void InstallApp(string appName){}
        
        public override void InstallApp() {
            Console.WriteLine("Type the name of the app you want to install");
            string appNameUnformatted =  Console.ReadLine();
            string appName = appNameUnformatted.Substring(0,1).ToUpper() + appNameUnformatted.Substring(1).ToLower();
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Openning App Store...");
            System.Threading.Thread.Sleep(1300);
            Console.WriteLine("Searching for the app...");
            System.Threading.Thread.Sleep(1800);
            Console.WriteLine("Select which version of the app you want to install");
            Console.WriteLine($" 1 - {appName} \n 2 - {appName} Light ");
            int appOption = Convert.ToInt16(Console.ReadLine());
            if (appOption == 1){
                appName = $"{appName}";
            }else if(appOption == 2){
                appName = $"{appName} Light";
            } else {
                Console.WriteLine("Invalid Option, try again please...");
                return;
            }
            System.Threading.Thread.Sleep(1400);
            Console.WriteLine($"Starting installation of {appName}, please wait");

            System.Threading.Thread.Sleep(650);

            for(int count = 0; count <= 100; count ++) {
                Console.WriteLine($"Downloading: {count}% , please wait");
                System.Threading.Thread.Sleep(55);
                if(count == 100) {
                    System.Threading.Thread.Sleep(850);
                }
                Console.Clear();
            }

            System.Threading.Thread.Sleep(690);

            Console.WriteLine("Verifying the app...");
            for(int count = 0; count <= 100; count ++) {
                Console.WriteLine($"Scanning for viruses, and verifying integrity: \n {count}% , please wait");
                System.Threading.Thread.Sleep(40);
                if(count == 100) {
                    System.Threading.Thread.Sleep(850);
                }
                Console.Clear();
            }
            Console.WriteLine("Installing the app");

            System.Threading.Thread.Sleep(500);

            for(int count = 0; count <= 100; count ++) {
                Console.WriteLine($"Installing app \n {count}% , please wait");
                System.Threading.Thread.Sleep(55);
                if(count == 100) {
                    System.Threading.Thread.Sleep(850);
                }
                Console.Clear();
            }

            Console.WriteLine($"App {appName} installed succesfully!");
            System.Threading.Thread.Sleep(800);
            Console.WriteLine($"Openning {appName}...");
        }
    }
}