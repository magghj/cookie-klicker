namespace cookie_klicker;

public class Game
{
    long amountOfCookies = 0;
    long addAmount = 1;
    long plusAmountOfCookies = 1;
    long costOfPlusUpgrade = 100;
    long funGabPlus = 1;
    long timesAmountOfCookies = 1;
    long costOfTimesUpgrade = 100;
    long funGabTimes = 1;

    public void click()
    {
        amountOfCookies += addAmount;
    }

    private void updateAddAmount()
    {
        addAmount = plusAmountOfCookies * timesAmountOfCookies;
    }

    public void plusClickUpgrade()
    {
        if (amountOfCookies < costOfPlusUpgrade)
            return;

        amountOfCookies -= costOfPlusUpgrade;
        plusAmountOfCookies++;
        funGabPlus++;
        costOfPlusUpgrade += funGabPlus * 100;
        updateAddAmount();
    }

    public void timesClickUpgrade()
    {
        if (amountOfCookies < costOfTimesUpgrade)
            return;

        amountOfCookies -= costOfTimesUpgrade;
        timesAmountOfCookies++;
        funGabTimes++;
        costOfTimesUpgrade += funGabTimes * 100;
        updateAddAmount();
    }

    public long plusAmound() => plusAmountOfCookies;
    public long costOfPlus() => costOfPlusUpgrade;
    public long timesAmound() => timesAmountOfCookies;
    public long costOfTimes() => costOfTimesUpgrade;
    public long cookieCount() => amountOfCookies;
    public long cookieAdder() => addAmount;
}