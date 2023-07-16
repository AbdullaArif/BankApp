namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choose, month = 0, remainingMonth = 0;
            float amount = 0, totalAmount = 0, monthlyPayment = 0, debt = 0;
        tryagain:
            Console.WriteLine("Enter  username:");
            string user_Name = Console.ReadLine();
            Console.WriteLine("enter password");
            string password = Console.ReadLine();

            if (user_Name != "admin" || password != "admin")
            {
                Console.WriteLine("username or paswword wrong");
                goto tryagain;
            }
            else
            {
                Console.WriteLine("Credit menu :");
                Console.WriteLine("1.Getting a loan");
                Console.WriteLine("2.credit payment");
                Console.WriteLine("3.Credit report");
                choose = int.Parse(Console.ReadLine());

            yenisecim:
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("enter the month");
                        Console.WriteLine("Less than 1 year 12%, more than 1 year 18%");
                        month = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter amount:");
                        amount = int.Parse(Console.ReadLine());
                        if (month <= 12)
                        {
                            totalAmount = (float)(amount + (amount * 0.12));
                            Console.WriteLine(totalAmount);
                        }
                        else
                        {
                            totalAmount = (float)(amount + (amount * 0.18));
                            Console.WriteLine(totalAmount);
                        }
                        Console.WriteLine("Credit menu :");
                        Console.WriteLine("1.Getting a loan");
                        Console.WriteLine("2.credit payment");
                        Console.WriteLine("3.Credit report");
                        choose = int.Parse(Console.ReadLine());
                        goto yenisecim;
                        break;

                    case 2:

                        if (totalAmount == 0)
                        {
                            Console.WriteLine("You have no credit");
                            Console.WriteLine("Credit menu :");
                            Console.WriteLine("1.Getting a loan");
                            Console.WriteLine("2.credit payment");
                            Console.WriteLine("3.Credit report");
                            choose = int.Parse(Console.ReadLine());
                            goto yenisecim;
                        }
                        else
                        {
                            Console.WriteLine("credit payment");
                            Console.WriteLine("Click 1 to pay a loan");
                            int secim2 = int.Parse(Console.ReadLine());
                            if (secim2 == 1)
                            {
                                Console.WriteLine("credit payment");
                                monthlyPayment = totalAmount / month;
                                Console.WriteLine("monthly payment:" + " " + monthlyPayment);
                                debt = totalAmount - monthlyPayment;
                                Console.WriteLine("Remaining debt:" + " " + debt);
                                remainingMonth = month - 1;
                                Console.WriteLine("Remaining Month:" + " " + remainingMonth);
                            }
                            else if (secim2 != 1)
                            {
                                Console.WriteLine("Failed operation");
                            }
                        }

                    yeniOdenis:
                        Console.WriteLine("Want to make a new remaining?");
                        Console.WriteLine("1.Yes");
                        Console.WriteLine("2.No");
                        int yeniOdenis = 0;
                        yeniOdenis = int.Parse(Console.ReadLine());
                        if (yeniOdenis == 1)
                        {
                            Console.WriteLine("Remaining Month:" + monthlyPayment);
                            debt = debt - monthlyPayment;
                            Console.WriteLine("Debt:" + debt);
                            remainingMonth--;
                            Console.WriteLine("residual month:" + remainingMonth);
                            goto yeniOdenis;
                        }
                        else if (yeniOdenis == 2)
                        {
                            Console.WriteLine("Credit menu :");
                            Console.WriteLine("1.Getting a loan");
                            Console.WriteLine("2.credit payment");
                            Console.WriteLine("3.Credit report");
                            choose = int.Parse(Console.ReadLine());
                            goto yenisecim;
                        }
                        break;

                    case 3:

                        if (totalAmount == 0)
                        {
                            Console.WriteLine("You have no credit");

                            Console.WriteLine("Credit menu :");
                            Console.WriteLine("1.Getting a loan");
                            Console.WriteLine("2.credit payment");
                            Console.WriteLine("3.Credit report");
                            choose = int.Parse(Console.ReadLine());
                            goto yenisecim;
                        }
                        else
                        {
                            Console.WriteLine(monthlyPayment);
                            Console.WriteLine(debt);
                            Console.WriteLine(remainingMonth);
                        }
                        break;
                    default:
                        Console.WriteLine("the choice is incorrect");
                        break;
                }
            }
        }
    }
}
