namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public long CellphoneNumber {get ; set; }
        //TODO validate CellphoneNumber
        //     get{
        //         return this.CellphoneNumber;
        //     }
        //     set {
        //         if(CellphoneNumber.Equals(null) || CellphoneNumber.ToString().Length < 11|| (CellphoneNumber.GetType()==typeof(string)) ) {
        //             throw new Exception("Cellphone number can't be null, or text...");
        //         } else {
        //             this.CellphoneNumber = CellphoneNumber;
        //         }
        //     }
        // }
        public string Model { get; set; }
        public long IMEI { get; set; }
        //TODO validate IMEI
        //     get {
        //         return IMEI;
        //     }
        //     set {
        //         if(IMEI.Equals(null) || IMEI.ToString().Length < 15|| (IMEI.GetType()==typeof(string)) ) {
        //         throw new Exception("IMEI can't be null os string...");
        //         } else {
        //             this.IMEI = IMEI;
        //         }
        //     }
        //  }
        public int Memory { get; set; }
        public int StorageCapacity { get; set;}
        public Smartphone(long cellphoneNumber,string model, long imei, int memory, int storageCapacity)
        {
            CellphoneNumber = cellphoneNumber;
            Model = model;
            IMEI = imei;
            Memory = memory;
            StorageCapacity = storageCapacity;
            
        }

        public Smartphone () {}

        public void Call()
        {
            Console.WriteLine("Please type the number you want to call, only the numbers");
            try{
                long number = Convert.ToInt64(Console.ReadLine());
                string formattedNumber = NumberFormatter(number);
                Console.WriteLine($"Calling {formattedNumber} from {NumberFormatter(this.CellphoneNumber)}(your device)");
            }catch(Exception e){
                Console.WriteLine($" Invalid cellphone number, please try again \n {e.Message}");
            }
      
        }

        public void ReceiveCall()
        {
            string formattedCallingNumber;
            Random rnd = new Random();
            long callingNumber = Convert.ToInt64(rnd.NextInt64(10000000000, 99999999999));
            if (callingNumber > 70000000000) {
                formattedCallingNumber = "Unknown Number";
            } else {
                formattedCallingNumber = NumberFormatter(callingNumber);
            }

            Console.WriteLine($"Receiving call from {formattedCallingNumber}...");

            bool callMenu = true;
            Console.WriteLine("Accept or Decline the call...");
            while (callMenu) {
                Console.WriteLine(" 1 - Accept \n 2 - Decline");
                string acceptOrDeny = Console.ReadLine();
                if (acceptOrDeny == "1") {
                    Console.WriteLine("You accepted the call...");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }else if (acceptOrDeny == "2" ) {
                    Console.WriteLine("You rejected the call...");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }else {
                    Console.WriteLine("Invalid Option, please try again...");
                }
            }
        }

        public abstract void InstallApp();
        public abstract void InstallApp(string appName);

        public string NumberFormatter(long number) {
            string formattedNumber = String.Format("{0:#-###-###-####}", number);
            return formattedNumber;
        }

        public void ShowSpecs() {         
            Console.WriteLine($" Model: {(this.Model == null ? "Unknown" : this.Model)} \n" + 
            $" RAM: {(this.Memory == 0  ? "Unknown": this.Memory + " GB")} \n" + 
            $" Storage: {(this.StorageCapacity == 0 ? "Unknown" : this.StorageCapacity + " GB")}");
        }
    }

}