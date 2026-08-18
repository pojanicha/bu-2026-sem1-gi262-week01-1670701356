using System.Collections;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //As01_CheckNumberSign(); //Clear*
        //As02_GetDayName(); //Clear*
        As03_ValidatePassword(); //Clear*
        //As04_GetGrade(); //Clear*
        //As05_IsLeapYear();//Clear*
        //As06_Calculate(); //Clear*
        //As07_GetSeason(); //Clear*
        //As08_PurchasingSystemExample(); //Clear*
        //As09_RockPaperScissorsExample(); //Clear*
        //As10_CalculateWeaponDamage(); //Clear
        //As11_DeterminePlayerRank();  //Clear
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");

        if (as01Number >= 0)
        {
            Debug.Log("Positive");

        }
        else
        {
            Debug.Log("Negative");

        }
       


    }

    public int as02Day;
    public void As02_GetDayName()
    {
        // TODO: Implement logic to return day name
        // Example: Debug.Log("Monday");
        if (as02Day == 1)
        {
            Debug.Log("Monday");
        }

        else if (as02Day == 2)
        {
            Debug.Log("Tuesday");
        }

        else if (as02Day == 3)
        {
            Debug.Log("Wednesday");
        }
        else if (as02Day == 4)
        {
            Debug.Log("Thursday");
        }
        else if (as02Day == 5)
        {
            Debug.Log("Friday");
        }
        else if (as02Day == 6)
        {
            Debug.Log("Saturday");
        }
        else if (as02Day == 7)
        {
            Debug.Log("Sunday");
        }
     
        else
        {
            Debug.Log("Invalid day");
        }

    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        // TODO: Implement password validation logic
        // Example: Debug.Log("True");

        if (as03InputPassword == as03CorrectPassword)
        { 
            Debug.Log("True");


        }

        else
        {
            Debug.Log("False");
        }





    }

    public int as04Score;
    public void As04_GetGrade()
    {
        // TODO: Implement logic to return grade
        // Example: Debug.Log("A");
        if (as04Score >= 80 )
        {
            Debug.Log("A");

        }
        if (as04Score >= 66 && as04Score <= 79)
        {
            Debug.Log("B");

        }
        if (as04Score >= 51 && as04Score <= 65)
        {
            Debug.Log("C");

        }

        if (as04Score >= 50 && as04Score <= 55)
        {
            Debug.Log("D");

        }

        if (as04Score <= 49)
        {
            Debug.Log("F");

        }

    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        // TODO: Implement leap year check logic
        // Example: Debug.Log("True");

        if (as05Year % 400 == 0)
        { 
            Debug.Log("True");
        
        }
        else if (as05Year % 100 == 0)
        {
            Debug.Log("False");
        }
        else if (as05Year % 4 == 0)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }


    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public double result;
    public void As06_Calculate()
    {
        // TODO: Implement calculator logic
        // Example: Debug.Log("Result: 42");

        if (as06Op == '+')
        { 
           result = as06Num1 + as06Num2;
            Debug.Log($"Input : {as06Num1}, '{as06Op}', {as06Num2} Output: Result: {result}");

        }

        else if (as06Op == '-')
        {
            result = as06Num1 - as06Num2;
            Debug.Log($"Input : {as06Num1}, '{as06Op}', {as06Num2} Output: Result: {result}");

        }

        else if (as06Op == '*')
        {
            result = as06Num1 * as06Num2;
            Debug.Log($"Input : {as06Num1}, '{as06Op}', {as06Num2} Output: Result: {result}");
        }
        else if (as06Op == '/')
        {

            if (as06Num2 == 0)
            { 

                Debug.Log("Error: Division by zero");
            }
            else
            {
                result = as06Num1 / as06Num2;
                Debug.Log($"Input : {as06Num1}, '{as06Op}', {as06Num2} Output: Result: {result}");
            }
           
        }
        else
        {
            Debug.Log("Invalid operator, Please use + - * /");
        }

    }

    public int as07Month;
    public void As07_GetSeason()
    {
        // TODO: Implement logic to return season
        // Example: Debug.Log("Summer");
        
        if (as07Month == 12 || as07Month == 1 || as07Month == 2)
        {
            Debug.Log("Winter");
        }
        else if (as07Month >= 3 && as07Month <= 5)
        {
            Debug.Log("Spring");
        }
        else if (as07Month >= 6 && as07Month <= 8)
        {
            Debug.Log("Summer");
        }
        else if (as07Month >= 9 && as07Month <= 11)
        {
            Debug.Log("Fall");
        }
        else
        {
            Debug.Log(" Invalid month number. Please enter a number between 1 and 12");
        }




    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        if (as08Quantity <= 0)
        {
            Debug.Log($"Out of stock");

        }

        else if (as08Quantity > 0)
        {
            if (as08Payment >= as08Price)
            {
                Debug.Log($"Purchase successful.");

                if (as08Payment > as08Price)
                { 
                    int change = as08Payment - as08Price;
                    Debug.Log($"Change: {change}");

                }

            }

            else if (as08Payment < as08Price)
            {
                Debug.Log($"Not enough cash");
            }

        }



    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        switch (as09UserChoice)
        {
            case 0:
                if (as09ComputerChoice == 0)
                {
                    Debug.Log("Draw!");
                }
                else if (as09ComputerChoice == 1)
                {
                    Debug.Log("You lose!");
                }
                else if (as09ComputerChoice == 2)
                {
                    Debug.Log("You win!");
                }
                break;

            case 1:
                if (as09ComputerChoice == 0)
                {
                    Debug.Log("You win!");
                }
                else if (as09ComputerChoice == 1)
                {
                    Debug.Log("Draw!");
                }
                else if (as09ComputerChoice == 2)
                {
                    Debug.Log("You lose!");
                }
                break;

            case 2:
                if (as09ComputerChoice == 0)
                {
                    Debug.Log("You lose!");
                }
                else if (as09ComputerChoice == 1)
                {
                    Debug.Log("You win!");
                }
                else if (as09ComputerChoice == 2)
                {
                    Debug.Log("Draw!");
                }
                break;

            default:
                Debug.Log("Invalid user choice");
                return;
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
        double multiplier = 1.0;

        switch (as10WeaponType?.ToLower())
        {
            case "sword":
                multiplier = 1.3;
                break;
                
            case "axe":
                multiplier = 1.4;
                break;

            case "bow":
                multiplier = 1.2;
                break;

            case "staff":
                multiplier = 1.5;
                break;

            case "dagger":
                multiplier = 1.1;
                break;

            default: 
                multiplier = 1.0;
                break;

        }

        int totalDamage = (int)(as10BaseDamage * multiplier);
        Debug.Log(totalDamage.ToString());

    }
   

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        // TODO: Add your implementation here
        // Example: Debug.Log("result as string");
     

        if (as11Score < 0)
        {
            Debug.Log("Invalid score");
            return;
        }

        string rank;
        int baseCoins;

        if (as11Score >= 8000) 
        { 
            rank = "Gold";
            baseCoins = 100;
        }
        else if (as11Score >= 6000 && as11Score <= 7999) 
        { 
            rank = "Silver";
            baseCoins = 75;
        }
        else if (as11Score >= 4000 && as11Score <= 5999) 
        { 
            rank = "Bronze";
            baseCoins = 50;
        }
        else if (as11Score >= 0 && as11Score <= 3999) 
        { 
            rank = "Participation";
            baseCoins = 25;
        }
        else
        {
           Debug.Log("Invalid score or time");
            return;
        }


        int timeBonus = 0;

        if (as11CompletionTime <= 30)
        {
            timeBonus = 25;
        }

        else if (as11CompletionTime >= 31 && as11CompletionTime <= 60)
        {
            timeBonus = 10;
        }
        else
        {
            timeBonus = 0;
        }



        int totalCoins = baseCoins + timeBonus;
        Debug.Log($"{rank} Rank - {totalCoins} coins earned!");

    }
}
