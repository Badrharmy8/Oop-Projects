using System;

class Data
{
    double numOne;
    double numTwo;

    // setter and getter for numOne
    public void setNumOne(double numOne)
    {
        this.numOne = numOne;
    }

    public double getNumOne()
    {
        return this.numOne;
    }

    // setter and getter for numTwo
    public void setNumTwo(double numTwo)
    {
        this.numTwo = numTwo;
    }

    public double getNumTwo()
    {
        return this.numTwo;
    }

}

// addition operation
class Add : Data
{
    public double operation()
    {
        return getNumOne() + getNumTwo();
    }
}

// subtraction operation
 class Sub : Data
{
    public double operation()
    {
        return getNumOne() - getNumTwo();
    }
}

// multiplication operation
class Mul : Data
{
    public double operation()
    {
        return getNumOne() * getNumTwo();
    }
}

// division operation
class Div : Data
{
    public double operation()
    {
        return getNumOne() / getNumTwo();
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Add add = new Add();
        Sub sub = new Sub();
        Mul mul = new Mul();
        Div div = new Div();
        Console.WriteLine("Enter The First Number : ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter The Second Number : ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Choose The Operation {Addition , Subtraction , Multiplication , Division}");
        string operation = Console.ReadLine();
        if(operation.ToLower() == "addition" || operation.ToLower() == "add")
        {
            add.setNumOne(num1);
            add.setNumTwo(num2);
            Console.WriteLine(num1 + " + " + num2 + " = " + add.operation());
        }
        else if(operation.ToLower() == "subtraction" || operation.ToLower() == "sub")
        {
            sub.setNumOne(num1);
            sub.setNumTwo(num2);
            Console.WriteLine(num1 + " - " + num2 + " = " + sub.operation());
        }
        else if (operation.ToLower() == "multiplication" || operation.ToLower() == "mul")
        {
            mul.setNumOne(num1);
            mul.setNumTwo(num2);
            Console.WriteLine(num1 + " * " + num2 + " = " + mul.operation());
        }
        else if (operation.ToLower() == "division" || operation.ToLower() == "div")
        {
            div.setNumOne(num1);
            div.setNumTwo(num2);
            Console.WriteLine(num1 + " / " + num2 + " = " + div.operation());
        }
    }
}
