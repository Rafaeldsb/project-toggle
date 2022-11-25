using ProjectToggle.Domain.Entities;

namespace ProjectToggle.Domain.ValueObjects;

public class StrategyFormula
{
    public string formula;

    public List<StrategyConfig> strategies;

    public bool isEnabled()
    {
        throw new NotImplementedException();
    }
}

public class StrategyConfig
{
    public Strategy strategy;

    public object data;
}