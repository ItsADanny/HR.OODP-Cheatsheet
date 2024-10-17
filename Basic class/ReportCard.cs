public class ReportCards {
    public List<double> Numbers = new List<double>();

    //if we aren't going to need a constructor (because we don't initialize anything), then we don't need
    //to declare it. But you can still do this if you want
    public ReportCard() {

    }

    //Basic methods
    public void AddNumber(double number) {
        Numbers.Add(number);
    }

    public void DidSucceed() {
        foreach(double number in Numbers) {
            if (number >= 5.5) {
                Console.Writeline($"{number}, you succeeded");
            } else {
                Console.Writeline($"{number}, you failed");
            }
        }
    }
}