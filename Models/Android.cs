namespace DesafioPOO.Models
{
    public class Android : Smartphone
    {
        public Android(long cellphoneNumber, string model, long imei, int memory, int storageCapacity) : base(cellphoneNumber, model, imei, memory,storageCapacity)
        {
             
        }
 
        public override void InstallApp(string appName){}
        public override void InstallApp() {

            Console.WriteLine("Type the name of the app you want to install");
            string appNameUnformatted =  Console.ReadLine();
            string appName = appNameUnformatted.Substring(0,1).ToUpper() + appNameUnformatted.Substring(1).ToLower();
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Openning Google Play Store...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Searching for the app...");
            System.Threading.Thread.Sleep(1400);
            Console.WriteLine("Select which version of the app you want to install");
            Console.WriteLine($" 1 - {appName} \n 2 - {appName} Light \n 3 - {appName} v2");
            int appOption = Convert.ToInt16(Console.ReadLine());
            if (appOption == 1){
                appName = $"{appName}";
            }else if (appOption == 2) {
                appName = $"{appName} Light";
            } else if(appOption == 3){
                appName = $"{appName} v2";
            } else {
                Console.WriteLine("Invalid Option, try again please...");
                return;
            }
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Starting installation of {appName}, please wait");

            System.Threading.Thread.Sleep(500);

            for(int count = 0; count <= 100; count ++) {
                Console.WriteLine($"Downloading: {count}% , please wait");
                System.Threading.Thread.Sleep(65);
                if(count == 100) {
                    System.Threading.Thread.Sleep(500);
                }
                Console.Clear();
            }

            System.Threading.Thread.Sleep(500);

            Console.WriteLine("Verifying the app...");
            for(int count = 0; count <= 100; count ++) {
                Console.WriteLine($"Scanning for viruses, and verifying integrity: \n {count}% , please wait");
                System.Threading.Thread.Sleep(20);
                if(count == 100) {
                    System.Threading.Thread.Sleep(500);
                }
                Console.Clear();
            }
            Console.WriteLine("Installing the app");

            System.Threading.Thread.Sleep(500);

            for(int count = 0; count <= 100; count ++) {
                Console.WriteLine($"Installing app \n {count}% , please wait");
                System.Threading.Thread.Sleep(35);
                if(count == 100) {
                    System.Threading.Thread.Sleep(500);
                }
                Console.Clear();
            }

            Console.WriteLine($"App {appName} installed succesfully!");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"Openning {appName}...");
        }



    }
}