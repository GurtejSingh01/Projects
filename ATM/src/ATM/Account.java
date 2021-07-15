package ATM;

import java.util.Date;

public class Account {

    private String _customerName;
    private int _customerId;
    private double _balance;
    private double _annualInterestRate;
    private final Date date;

    Account(int customerId, String customerName) {
        _customerId = customerId;
        _customerName = customerName;
        date = new Date();
    }

    public String getCustomerName() {
        return _customerName;
    }

    public int getCustomerId() {
        return _customerId;
    }

    public double getBalance() {
        return _balance;
    }

    public double getAnnualInterestRate() {
        return _annualInterestRate;
    }

    public Date getDate() {
        return date;
    }

    public void setCustomerName(String customerName) {
        _customerName = customerName;
    }

    public void setCustomerId(int customerId) {
        _customerId = customerId;
    }

    public void setBalance(double balance) {
        _balance = balance;
    }

    public void setAnnualInterestRate(double annualInterestRate) {
        _annualInterestRate = annualInterestRate;
    }

    public void deposit(double value) {
        _balance = _balance + value;
    }

    public void withdraw(double value) {
        _balance = _balance - value;
    }

    public double monthlyInterest() {
        double monthlyInterest;
        monthlyInterest = _annualInterestRate / 12;
        return (_balance * monthlyInterest) / 100;
    }
}
