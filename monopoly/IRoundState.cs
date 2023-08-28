using System.Text.Json.Serialization.Metadata;

interface IRoundState
{
    IRoundState Update(IMonopolyDelegate monoply);
   
}
