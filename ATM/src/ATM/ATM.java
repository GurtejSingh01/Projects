
package ATM;
import java.util.Scanner;
import java.text.SimpleDateFormat ;


public class ATM {

    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args) {

        int Id;

        Account acct1 = new Account(101,"Gurtej Singh");
        Account acct2 = new Account(102,"Sidhu");

        acct1.setBalance(50);
        acct1.setAnnualInterestRate(5);
        acct2.setBalance(1000);
        acct2.setAnnualInterestRate(5);

        do{
            System.out.print("Enter Your ID: ");
            Id = scanner.nextInt();

            if(Id == 101)
            {
                menu(acct1);
            }
            else
            {
                if(Id == 102)
                {
                    menu(acct2);
                }
                else{
                    System.out.println("Please Enter a correct ID !");
                }
            }
        }while(Id != 101 && Id != 102);
    }

    public static void menu(Account acct)
    {
        int select;
        do{
            System.out.println("\n Main Menu");
            System.out.println("1: Account Info");
            System.out.println("2: Withdraw");
            System.out.println("3: Deposit");
            System.out.println("4: Exit");
            System.out.print("Please choose what you'd like to do: ");
            select = scanner.nextInt();
            if(select == 1)
            {
                accountInfo(acct);
            }
            else{
                if(select == 2)
                {
                    withdrawAmount(acct);
                }
                else{
                    if(select == 3)
                    {
                        depositAmount(acct);
                    }
                    else{
                        if(select == 4)
                        {
                            String[] Id = null;
                            ATM.main(Id);
                            return;
                        }
                        else{
                            System.out.println("\n Invalid Choice !");
                        }
                    }
                }
            }
        }while(select != 4);
    }

    public static void accountInfo(Account acct)
    {
        SimpleDateFormat formatter = new SimpleDateFormat("dd/MM/yyyy HH:mm:ss");  
        System.out.println("\nCustomer: "+acct.getCustomerName());
        System.out.println("Account Balance: $"+ acct.getBalance());
        System.out.println("Monthly Interest Earned: $"+String.format("%.2f", acct.monthlyInterest()));
        System.out.println("Date of account created: "+ formatter.format(acct.getDate()));

        
    }
    public static void withdrawAmount(Account acct)
    {
        double amount;
        System.out.print("Enter the amount to withdraw: ");
        amount = scanner.nextInt();
        acct.withdraw(amount);
    }
    public static void depositAmount(Account acct)
    {
        double amount;
        System.out.print("Enter the amount to deposit: ");
        amount = scanner.nextInt();
        acct.deposit(amount);
    }
}

/****/


