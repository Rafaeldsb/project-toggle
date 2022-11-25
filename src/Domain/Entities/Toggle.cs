using ProjectToggle.Domain.Common;
using ProjectToggle.Domain.ValueObjects;

namespace ProjectToggle.Domain.Entities;

public class Toggle : BaseEntity
{
    public string projectId;
    
    public string name;

    public string slug;

    public bool active;

    public List<string> tags;

    public StrategyFormula strategyFormula;
}