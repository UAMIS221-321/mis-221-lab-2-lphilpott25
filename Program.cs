//know how to use %
//constants are all caps

const double COST_OF_SANDWICH = 4.75;
const double COST_OF_TOPPING = 0.55;
const double DISCOUNT_AMOUNT = 0.1;

int numberOfSandwiches = 0;
int numberOfToppings = 0;
double tip = 0;

System.Console.WriteLine("How many sandwich do you want?");
numberOfSandwiches = int.Parse(Console.ReadLine()); 

System.Console.WriteLine("enter nember of toppings");
tip = double.Parse(Console.ReadLine());

System.Console.WriteLine("Enter tip amount");
tip = double.Parse(Console.ReadLine());

double totalSandWichCOst = COST_OF_SANDWICH * numberOfSandwiches;
double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
double baseCost = totalSandWichCOst + totalToppingCost;

double orderCost = tip + baseCost*(1-DISCOUNT_AMOUNT);
System.Console.WriteLine("Your total Cost is " + orderCost);


