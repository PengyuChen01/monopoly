using System.Text.Json.Serialization.Metadata;

class StateDecision : IRoundState
{
    public IRoundState Update(IMonopolyDelegate monoply)
    {
        return this;
    }
}
