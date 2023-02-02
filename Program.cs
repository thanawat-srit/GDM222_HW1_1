class Program{
    static void Main(string[] args){
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine(f(x));
    }
    static double f(double x){
        double sum = 0;
        if(Math.Pow(x,2)<= 4){
            sum = 2;
        }else if(Math.Pow(x,2)> 4){
            sum = 1+f(x-4*Math.Abs(x)/x);
        }
        return sum;
    }
}
