using System;

class GoodBattery : IBattery
{
    public string GetName()
    {
        return "고급 배터리";
    }
}

class NormalBattery : IBattery
{
    public string GetName()
    {
        return "일반 배터리";
    }
}