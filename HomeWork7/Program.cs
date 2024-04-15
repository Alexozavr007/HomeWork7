
#region Task 2 
Console.WriteLine("Lesson 7. Task 2");
Console.WriteLine("================");


int Add(int a, int b) {
    return  a + b;
}

int Sub(int a, int b) {
    return a - b;
}

int Mul(int a, int b) {
    return a * b;
}

double Div(int a, int b) {
    if (b != 0)
        return (double)a / b;
    else {
        return double.NaN;
    }
}


Console.Write("Enter the first number: ");
int first  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int second = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the operation symbol ( + - * / ): ");
string sign = Console.ReadLine();


if (sign == "+") {
    Console.WriteLine(Add(first, second));
} else if (sign == "-") {
    Console.WriteLine(Sub(first, second));
} else if (sign == "*") {
    Console.WriteLine(Mul(first, second));
} else if (sign == "/") {
    double c = Div(first, second);
    if (c == double.NaN) {
        Console.WriteLine("Division by zero!");
    } else
        Console.WriteLine(c);
} else {
    Console.WriteLine("Unexpected operation symbol!");
}

#endregion


#region Task 4

void NumberVerification (int num) {
    if (num > 0) {
        Console.WriteLine($"{num} is positive");
    }else if (num < 0) {
        Console.WriteLine($"{num} is negative");
    }else {
        Console.WriteLine($"{num} is zero");
    }


    bool isPrimeNumber = true;
    for (int i = 2; i < num; i++) {
        if(num % i == 0) {
            isPrimeNumber = false;
            break;
        }
    }
    if (isPrimeNumber) {
        Console.WriteLine($"{num} is prime number");
    }else {
        Console.WriteLine($"{num} is not prime number");
    }

    Console.WriteLine($"Is reminder after dividing {num} by 2 exist? -> " + ((num % 2 == 0) ? "No" : "Yes"));
    Console.WriteLine($"Is reminder after dividing {num} by 5 exist? -> " + ((num % 5 == 0) ? "No" : "Yes"));
    Console.WriteLine($"Is reminder after dividing {num} by 3 exist? -> " + ((num % 3 == 0) ? "No" : "Yes"));
    Console.WriteLine($"Is reminder after dividing {num} by 6 exist? -> " + ((num % 6 == 0) ? "No" : "Yes"));
    Console.WriteLine($"Is reminder after dividing {num} by 9 exist? -> " + ((num % 9 == 0) ? "No" : "Yes"));

}
Console.WriteLine();
Console.WriteLine("Lesson 7. Task 4");
Console.WriteLine("================");

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());
NumberVerification(num);

#endregion



void average(int num1, int num2, int num3){


    Console.Write((num1 + num2 + num3) / 3);


}



#region Task 6
Console.WriteLine();
Console.WriteLine("Lesson 7. Task 6");
Console.WriteLine("================");

Console.Write("Enter the number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number: ");
int num3 = Convert.ToInt32(Console.ReadLine());


average(num1, num2, num3);

#endregion

#region Task 3 
Console.WriteLine();
Console.WriteLine("Lesson 7. Task 3");
Console.WriteLine("================");

Console.Write("Enter the amount of money: ");
int money = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter conversion course: ");
double course = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(money * course);

#endregion