namespace RefactoringLab;

public interface IShippingStrategy
{
    decimal CalculateCost(decimal weightKg);
}
public class AramexShippingCostCalculator : IShippingStrategy
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 12m;
    
}
public class FedExShippingCostStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 15m;
}

public class DHLShippingCostCalculator : IShippingStrategy
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 18m;
}

//R5
public class UperShippingCostStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weightKg) => weightKg * 20m;
}

public class ShippingCostCalculator
{
    public decimal Calculate(IShippingStrategy strategy, decimal weightKg)
    {
        
        return strategy.CalculateCost(weightKg);
    }
}
